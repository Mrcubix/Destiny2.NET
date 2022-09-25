namespace API.Entities.Definitions
{
    public class DestinyActivityChallengeDefinition : DestinyDefinition
    {
        public uint ObjectiveHash { get; set; }
        public DestinyItemQuantity[] DummyRewards { get; set; }
    }
}