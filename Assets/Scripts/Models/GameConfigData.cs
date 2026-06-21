using System;
using System.Collections.Generic;

namespace WordsOnTheWaves.Models
{
    [Serializable]
    public class DropRateData
    {
        public string genre;
        public float rate;
    }

    [Serializable]
    public class CargoCrateData
    {
        public string crateId;
        public string crateName;
        public int price;
        public List<DropRateData> dropRates;
    }

    [Serializable]
    public class MapLocationData
    {
        public string locationId;
        public string locationName;
        public int travelFee;
        public List<string> targetAudiences;
    }

    [Serializable]
    public class GameConfigData
    {
        public List<MapLocationData> mapLocations;
        public List<CargoCrateData> cargoCrates;
    }
}
