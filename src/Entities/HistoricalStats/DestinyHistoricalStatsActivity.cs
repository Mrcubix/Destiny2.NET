namespace API.Entities.HistoricalStats
{
    public class DestinyHistoricalStatsActivity
    {
        // TODO: map Hash to Destiny.Definitions.DestinyActivityDefinition
        public uint ReferenceId {get; set; }
        // TODO: map Hash to Destiny.Definitions.DestinyActivityDefinition
        public uint DirectorActivityHash { get; set; }
        public long _instanceId { get; set; }
        public int Mode { get; set; }
        public int[] Modes { get; set; }
        public bool IsPrivate { get; set; }
        public int MembershipType { get; set; }
    }
}