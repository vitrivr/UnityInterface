﻿using System.Collections.Generic;
using CineastUnityInterface.Runtime.Vitrivr.UnityInterface.CineastApi.Models;

namespace CineastUnityInterface.Runtime.Vitrivr.UnityInterface.CineastApi.Processing {
    public interface FilterStrategy {

        /**
         * <summary>Filters some mmos out and returnes the filtered list</summary>
         */
        List<MultimediaObject> applyFilter(List<MultimediaObject> list);
    }
}