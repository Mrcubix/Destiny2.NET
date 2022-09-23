namespace API.Entities.Definitions.Common
{
    public class DestinyDisplayPropertiesDefinition
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public DestinyIconSequenceDefinition IconSequences { get; set; }
        public string HighResIcon { get; set; }
        public bool HasIcon { get; set; }
    }
}