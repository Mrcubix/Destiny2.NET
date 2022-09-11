using API.Entities.Characters;
using API.Entities.Response.Base;
using API.Enums;

namespace API.Entities.Response.Profile
{
    public class ProfileDestinyCharactersResponse : ProfileComponentResponse
    {
        public Dictionary<string, Dictionary<long, SingleComponentResponseOf<DestinyCharacterComponent>>> Response { get; set; }
        new public DestinyComponentType Component = DestinyComponentType.Characters;
    }
}