using API.Entities.Definitions.Common;

namespace API.Entities.Definitions
{
    public class DestinyClassDefinition : DestinyDefinition
    {
        public int ClassType { get; set; }
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public Dictionary<int, string> GenderedClassNames { get; set; }
        public Dictionary<uint, string> GenderedClassNamesByGenderHash { get; set; }
        public uint? MentorVendorHash { get; set; }
    }
}