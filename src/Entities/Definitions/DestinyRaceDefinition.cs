using API.Entities.Definitions.Common;

namespace API.Entities.Definitions
{
    public class DestinyRaceDefinition : DestinyDefinition
    {
        public int RaceType { get; set; }
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public Dictionary<int, string> GenderedRaceNames { get; set; }
        public Dictionary<uint, string> GenderedRaceNamesByGenderHash { get; set; }
    }
}