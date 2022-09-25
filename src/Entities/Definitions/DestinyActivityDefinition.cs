using API.Entities.Definitions.Common;
using Tracker.API.Constants;

namespace API.Entities.Definitions
{
    public class DestinyActivityDefinition : DestinyDefinition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public DestinyDisplayPropertiesDefinition OriginalDisplayProperties { get; set; }
        public DestinyDisplayPropertiesDefinition SelectionScreenDisplayProperties { get; set; }
        public string ReleaseIcon { get; set; }
        public int ReleaseTime { get; set; }
        public int ActivityLightLevel { get; set; }
        public uint destinationHash { get; set; }
        public uint PlaceHash { get; set; }
        public uint ActivityTypeHash { get; set; }
        public int Tier { get; set; }
        public string PgcrImage { get; set; }
        public DestinyActivityRewardDefinition[] Rewards { get; set; }
        public DestinyActivityModifierReferenceDefinition[] Modifiers { get; set; }
        public bool IsPlaylist { get; set; }
        public DestinyActivityChallengeDefinition[] Challenges { get; set; }
        public DestinyActivityUnlockStringDefinition[] OptionalUnlockStrings { get; set; }
        public DestinyActivityPlaylistItemDefinition[] PlaylistItems { get; set; }
        public DestinyActivityGraphListEntryDefinition[] ActivityGraphList { get; set; }
        public DestinyActivityMatchmakingBlockDefinition Matchmaking { get; set; }
        public DestinyActivityGuidedBlockDefinition GuidedGame { get; set; }
        // TODO: Map Hash to definition
        public uint? DirectActivityModeHash { get; set; }
        public int? directActivityModeType { get; set; }
        public DestinyActivityLoadoutRequirementSet[] Loadouts { get; set; }
        public uint[] ActivityModeHashes { get; set; }
        public int[] ActivityModeTypes { get; set; }
        public bool IsPvP { get; set; }
        public DestinyActivityInsertionPointDefinition[] InsertionPoints { get; set; }
        public DestinyEnvironmentLocationMapping[] ActivityLocationMappings { get; set; }
    }
}