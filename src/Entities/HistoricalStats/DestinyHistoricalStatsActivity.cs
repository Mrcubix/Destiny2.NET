namespace API.Entities.HistoricalStats
{
    public class DestinyHistoricalStatsActivity
    {
        // TODO: map Hash to Destiny.Definitions.DestinyActivityDefinition
        public uint ReferenceId {get; set; }
        // TODO: map Hash to Destiny.Definitions.DestinyActivityDefinition
        public uint DirectorActivityHash { get; set; }
        private long _instanceId;
        public string InstanceId
        {
            get => _instanceId.ToString();
            set
            {
                long.TryParse(value, out _instanceId);
            }
        }
        public int Mode { get; set; }
        public int[] Modes { get; set; }
        public bool IsPrivate { get; set; }
        public int MembershipType { get; set; }

        public long GetInstanceId()
        {
            return _instanceId;
        }

        public void SetInstanceId(long id)
        {
            this._instanceId = id;
        }
    }
}