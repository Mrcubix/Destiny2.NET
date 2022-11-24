using API.Entities.Misc;

namespace API.Entities.Characters
{
    public class DestinyCharacterComponent
    {
        public long MembershipId { get; set; }
        public int MembershipType { get; set; }
        public long _characterId { get; set; }
        public DateTime DateLastPlayed { get; set; }
        public long MinutesPlayedThisSession { get; set; }
        public long MinutesPlayedTotal { get; set;}
        public int Light { get; set; }
        public Dictionary<uint, int> Stats { get; set; }
        public uint RaceHash { get; set; }
        public uint GenderHash { get; set; }
        public uint ClassHash { get; set; }
        public int RaceType { get; set; }
        public int ClassType { get; set; }
        public int GenderType { get; set; }
        public string EmblemPath { get; set; }
        public string EmblemBackgroundPath { get; set; }
        public uint EmblemHash { get; set; }
        public DestinyColor EmblemColor { get; set; }
        public DestinyProgression LevelProgression { get; set; }
        public int BaseCharacterLevel { get; set; }
        public float PercentToNextLevel { get; set; }
        public uint? TitleRecordHash { get; set; }
    }
}