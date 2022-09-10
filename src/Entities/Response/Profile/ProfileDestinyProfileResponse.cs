using API.Entities.Profiles;
using API.Entities.Response.Base;
using API.Enums;

namespace API.Entities.Response.Profile
{
    public class ProfileDestinyProfileResponse : ComponentResponse
    {
        public Dictionary<string, SingleComponentResponseOf<DestinyProfileComponent>> Response { get; set; }
        new public DestinyComponentType Component { get; } = DestinyComponentType.Profiles;
    }
}