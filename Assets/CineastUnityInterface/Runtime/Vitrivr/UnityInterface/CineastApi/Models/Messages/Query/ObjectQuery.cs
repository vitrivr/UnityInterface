﻿namespace CineastUnityInterface.Runtime.Vitrivr.UnityInterface.CineastApi.Models.Messages.Query
{
    /*
     * Stuff and things
     */
    [System.Serializable]
    public class ObjectQuery
    {
        public string[] ids;

        public ObjectQuery(string[] ids)
        {
            this.ids = ids;
        }
    }
}