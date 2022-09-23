using System;
using System.Collections.Generic;

namespace API.Entities.HistoricalStats
{
    public class DestinyHistoricalStatsPeriodGroup
    {
        public DateTime Period { get; set; }
        public DestinyHistoricalStatsActivity ActivityDetails { get; set; }
        public Dictionary<string, DestinyHistoricalStatsValue> Values { get; set; }
    }
}