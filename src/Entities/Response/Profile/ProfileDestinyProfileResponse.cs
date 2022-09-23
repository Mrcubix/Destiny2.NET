using API.Entities.Profiles;
using API.Entities.Response.Base;
using API.Enums;

namespace API.Entities.Response.Profile
{
    public class ProfileDestinyProfileResponse : ProfileComponentResponse
    {
        public DestinyProfileResponse Response { get; set; }
        public DestinyProfileComponent Profile => Response != null ? Response.Profile.Data : null;
        new public DestinyComponentType Component => DestinyComponentType.Profiles;
    }
}