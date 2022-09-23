using API.Entities.Challenges;

namespace API.Entities
{
    public class DestinyActivity
    {
        public uint ActivityHash { get; set; }
        public bool IsNew { get; set; }
        public bool CanLead { get; set; }
        public bool CanJoin { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsVisible { get; set; }
        public int? DisplayLevel { get; set; }
        public int? RecommendedLight { get; set; }
        public DestinyChallengeStatus[] Challenges { get; set; }
        public uint[] ModifierHashes { get; set; }
        public Dictionary<uint, bool> BooleanActivityOptions { get; set; }
        public int? LoadoutRequirementIndex { get; set; }
    }
}