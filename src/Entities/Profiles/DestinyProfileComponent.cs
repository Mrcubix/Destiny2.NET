using API.Entities.User;

namespace API.Entities.Profiles
{
    public class DestinyProfileComponent
    {
        public UserInfoCard UserInfo { get; set; }
        public DateTime DateLastPlayed { get; set; }
        public int VersionsOwned { get; set; }
        private long[] _CharacterIds;
        public string[] CharacterIds { 
            get => _CharacterIds.Select(x => x.ToString()).ToArray();
            set
            {
                _CharacterIds = value.Select(long.Parse).ToArray();
            }
        }
        public uint[] seasonHashes { get; set; }
        public uint[] EventCardHashesOwned { get; set; }
        public uint CurrentSeasonHash { get; set; }
        public int CurrentSeasonRewardPowerCap { get; set; }
    }
}