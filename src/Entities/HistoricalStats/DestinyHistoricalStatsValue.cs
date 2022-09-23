namespace API.Entities.HistoricalStats
{
    public class DestinyHistoricalStatsValue
    {
        public string StatId { get; set; }
        public DestinyHistoricalStatsValuePair Basic { get; set; }
        public DestinyHistoricalStatsValuePair Pga { get; set; }
        public DestinyHistoricalStatsValuePair Weighted { get; set; }
        private long _activityId;
        public string ActivityId
        {
            get => _activityId.ToString();
            set
            {
                long.TryParse(value, out _activityId);
            }
        }

        public long GetActivityId()
        {
            return _activityId;
        }

        public void SetActivityId(long id)
        {
            this._activityId = id;
        }
    }
}