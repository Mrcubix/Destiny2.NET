namespace API.Entities.HistoricalStats
{
    public class DestinyHistoricalStatsValue
    {
        public string StatId { get; set; }
        public DestinyHistoricalStatsValuePair Basic { get; set; }
        public DestinyHistoricalStatsValuePair Pga { get; set; }
        public DestinyHistoricalStatsValuePair Weighted { get; set; }
        public long ActivityId { get; set; }
    }
}