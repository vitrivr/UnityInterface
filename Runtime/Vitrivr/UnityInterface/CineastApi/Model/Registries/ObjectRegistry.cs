﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Org.Vitrivr.CineastApi.Model;

namespace CineastUnityInterface.Runtime.Vitrivr.UnityInterface.CineastApi.Model.Data
{
  /// <summary>
  ///   Class for instantiation and management of <see cref="ObjectData"/>.
  /// </summary>
  public static class ObjectRegistry
  {
    /// <summary>
    /// Internal storage and dictionary for media objects
    /// </summary>
    private static readonly ConcurrentDictionary<string, ObjectData> Registry = new ConcurrentDictionary<string, ObjectData>();

    /// <summary>
    /// Returns whether the registry has an item for the given id.
    /// </summary>
    /// <param name="id">The ObjectID to look for</param>
    /// <returns>TRUE if such an item exists, FALSE otherwise</returns>
    public static bool Exists(string id)
    {
      return Registry.ContainsKey(id);
    }

    /// <summary>
    /// Resets the registry by clearing all object entries.
    /// <b>Caution</b> This will actively clear the local cache.
    /// </summary>
    public static void Reset()
    {
      Registry.Clear();
    }

    /// <summary>
    ///   Retrieves the object for the given ID. If it does not exist, it will be created.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static ObjectData GetObject(string id)
    {
      if (!Exists(id))
      {
        Registry.TryAdd(id, new ObjectData(id));
      }
      return Registry[id];
    }

    /// <summary>
    /// Initialises the registry with data from a previously initialised <see cref="SegmentRegistry"/>
    /// </summary>
    /// <param name="withMeta">Whether to initialise with metadata or not</param>
    /// <returns></returns>
    public static async Task Initialize(bool withMeta = false)
    {
      if (withMeta)
      {
        await BatchFetchObjectDataWithMeta(SegmentRegistry.GetObjects());
      }
      else
      {
        await BatchFetchObjectData(SegmentRegistry.GetObjects());
      }
    }

    public static ObjectData GetObjectOf(string segmentId)
    {
      if (!SegmentRegistry.Exists(segmentId))
      {
        throw new ArgumentException($"The given segment id '{segmentId}' is not known to the registry");
      }

      return SegmentRegistry.GetObjectOf(segmentId);
    }
    
    public static async Task BatchFetchObjectData(List<ObjectData> objects)
    {
      var toInit = objects.Where(obj => !obj.Initialized).Select(obj => obj.Id).ToList();
      var results = await Task.Run(() => CineastWrapper.ObjectApi.FindObjectsByIdBatched(new IdList(toInit)));
      results.Content.ForEach(dto => GetObject(dto.ObjectId).Initialize(dto));
    }

    public static async Task BatchFetchObjectDataWithMeta(List<ObjectData> objects)
    {
      var tasks = new List<Task> {BatchFetchObjectData(objects), BatchFetchObjectMetadata(objects)};
      while (tasks.Count > 0)
      {
        Task finished = await Task.WhenAny(tasks);
        tasks.Remove(finished);
      }
    }

    public static async Task BatchFetchObjectMetadata(List<ObjectData> objects)
    {
      var toInitObj = objects.Where(obj => !obj.Metadata.Initialized).ToList();
      var toInit = toInitObj.Select(obj => obj.Id).ToList();
      var result = await Task.Run(() =>
        CineastWrapper.MetadataApi.FindMetadataForObjectIdBatchedAsync(new OptionallyFilteredIdList(ids: toInit)));
      foreach (var obj in toInitObj)
      {
        obj.Metadata.Initialize(result);
      }
    }
    
    
  }
}