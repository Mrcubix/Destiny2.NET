namespace API.Entities.Definitions
{
    public class DestinyActivityGuidedBlockDefinition : DestinyDefinition
    {
        public int GuidedMaxLobbySize { get; set; }
        public int GuidedMinLobbySize { get; set; }
        public int GuidedDisbandCount { get; set; }
    }
}