using API.Entities.User;

namespace API.Entities.Profiles
{
    public class DestinyProfileComponent
    {
        public UserInfoCard UserInfo { get; set; }
        public DateTime DateLastPlayed { get; set; }
        public int VersionsOwned { get; set; }
        public long[] _CharacterIds { get; set; }
        public uint[] seasonHashes { get; set; }
        public uint[] EventCardHashesOwned { get; set; }
        public uint CurrentSeasonHash { get; set; }
        public int CurrentSeasonRewardPowerCap { get; set; }
    }
}