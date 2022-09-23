namespace API.Entities.Definitions
{
    public class DestinyActivityMatchmakingBlockDefinition
    {
        public bool IsMatchmade { get; set; }
        public int MinParty { get; set; }
        public int MaxParty { get; set; }
        public int MaxPlayers { get; set; }
        public bool RequiresGuardianOath { get; set; }
    }
}