using API.Entities.Characters;
using API.Entities.Response.Base;
using API.Enums;

namespace API.Entities.Response.Profile
{
    public class ProfileDestinyCharacterActivitesResponse : ComponentResponse
    {
        public Dictionary<string, SingleComponentResponseOf<DestinyCharacterActivitiesComponent>> Response { get; set; }
        new public DestinyComponentType Component { get; } = DestinyComponentType.CharacterActivities;
    }
}