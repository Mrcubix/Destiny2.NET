using API.Entities.Misc;

namespace API.Entities.Characters
{
    public class DestinyCharacterComponent
    {
        private long _membershipId;
        public string MembershipId
        {
            get => _membershipId.ToString();
            set
            {
                long.TryParse(value, out _membershipId);
            }
        }
        public int MembershipType { get; set; }
        private long _characterId;
        public string CharacterId
        {
            get => _characterId.ToString();
            set
            {
                long.TryParse(value, out _characterId);
            }
        }
        public DateTime DateLastPlayed { get; set; }
        private long _minutesPlayedThisSession;
        public string MinutesPlayedThisSession
        {
            get => _minutesPlayedThisSession.ToString();
            set
            {
                long.TryParse(value, out _minutesPlayedThisSession);
            }
        }
        private long _minutesPlayedTotal;
        public string MinutesPlayedTotal
        {
            get => _minutesPlayedTotal.ToString();
            set
            {
                long.TryParse(value, out _minutesPlayedTotal);
            }
        }
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

        public long GetMembershipId()
        {
            return _membershipId;
        }

        public void SetMembershipId(long id)
        {
            this.MembershipId = id.ToString();
        }

        public long GetCharacterId()
        {
            return _characterId;
        }

        public void SetCharacterId(long id)
        {
            this.CharacterId = id.ToString();
        }

        public long GetMinutesPlayedThisSession()
        {
            return _minutesPlayedThisSession;
        }

        public void SetMinutesPlayedThisSession(long time)
        {
            this.MinutesPlayedThisSession = time.ToString();
        }

        public long GetMinutesPlayedTotal()
        {
            return _minutesPlayedTotal;
        }

        public void SetMinutesPlayedTotal(long time)
        {
            this.MinutesPlayedTotal = time.ToString();
        }
    }
}