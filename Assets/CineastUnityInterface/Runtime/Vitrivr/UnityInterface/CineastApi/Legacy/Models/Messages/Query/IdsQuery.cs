﻿namespace CineastUnityInterface.Runtime.Vitrivr.UnityInterface.CineastApi.Legacy.Models.Messages.Query
{
    [System.Serializable]
    public class IdsQuery
    {
        public string[] ids;

        public IdsQuery(string[] ids)
        {
            this.ids = ids;
        }
    }
}