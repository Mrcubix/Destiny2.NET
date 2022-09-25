namespace API.Entities.Definitions
{
    public class DestinyActivityRewardDefinition : DestinyDefinition
    {
        public string RewardText { get; set; }
        public DestinyItemQuantity[] RewardItems { get; set; }
    }
}