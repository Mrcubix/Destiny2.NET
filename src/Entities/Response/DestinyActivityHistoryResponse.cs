using System.Collections.Generic;
using API.Entities.HistoricalStats;
using API.Entities.Response.Base;
using API.Enums;

namespace API.Entities.Response
{
    public class DestinyActivityHistoryResponse : APIResponse
    {
        public Dictionary<string, DestinyHistoricalStatsPeriodGroup[]> Response { get; set; }
    }
}