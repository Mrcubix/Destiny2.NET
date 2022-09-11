namespace API.Entities.Definitions
{
    public class DestinyActivityRewardDefinition
    {
        public string RewardText { get; set; }
        public DestinyItemQuantity[] RewardItems { get; set; }
    }
}