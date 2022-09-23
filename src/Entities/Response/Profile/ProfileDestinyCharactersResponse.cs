using API.Entities.Characters;
using API.Entities.Response.Base;
using API.Enums;

namespace API.Entities.Response.Profile
{
    public class ProfileDestinyCharactersResponse : ProfileComponentResponse
    {
        public DestinyCharacterResponse Response { get; set; }
        public SingleComponentResponseOf<DestinyCharacterComponent> Character => Response != null ? Response.Characters : null;
        new public DestinyComponentType Component => DestinyComponentType.Characters;
    }
}