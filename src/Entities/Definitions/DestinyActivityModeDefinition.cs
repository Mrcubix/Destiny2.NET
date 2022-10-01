using API.Entities.Definitions.Common;

namespace API.Entities.Definitions
{
    public class DestinyActivityModeDefinition : DestinyDefinition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public string PgcrImage { get; set; }
        public int ModeType { get; set; }
        public int ActivityModeCategory { get; set; }
        public bool IsTeamBased { get; set; }
        public bool IsAggregateMode { get; set; }
        public uint[] parentHashes { get; set; }
        public string FriendlyName { get; set; }
        public Dictionary<uint, int> ActivityModeMappings { get; set; }
        public bool Display { get; set; }
        public int Order { get; set; }
    }
}