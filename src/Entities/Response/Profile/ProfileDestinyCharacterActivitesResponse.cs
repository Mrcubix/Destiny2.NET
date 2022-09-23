using API.Entities.Characters;
using API.Entities.Response.Base;
using API.Enums;

namespace API.Entities.Response.Profile
{
    public class ProfileDestinyCharacterActivitesResponse : ProfileComponentResponse
    {
        public DestinyProfileResponse Response { get; set; }
        public Dictionary<long, DestinyCharacterActivitiesComponent> CharacterActivities => Response != null ? Response.CharacterActivities.Data : null;
        new public DestinyComponentType Component => DestinyComponentType.CharacterActivities;
    }
}