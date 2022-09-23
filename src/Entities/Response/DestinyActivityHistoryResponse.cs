using API.Entities.HistoricalStats;
using API.Entities.Response.Base;

namespace API.Entities.Response
{
    public class DestinyActivityHistoryResponse : APIResponse
    {
        public DestinyActivityHistoryResults Response { get; set; }
    }
}