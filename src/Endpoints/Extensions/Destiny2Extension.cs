using System.Text.Json;
using API.Entities.Characters;
using API.Enums;

namespace API.Endpoints
{
    public static class Destiny2Extension
    {
        public static async Task<DestinyCharacterActivitiesComponent> GetCurrentActivity(this Destiny2 api, int type, long id, long characterId)
        {
            if (string.IsNullOrEmpty(api.settings.Key))
                throw Destiny2.InvalidAPIKeyException;

            string serializedResponse = await api.SendRequest("GET", new Uri($"{Destiny2.BaseUrl}/Destiny2/{type}/Profile/{id}/Character/{characterId}/?components={DestinyComponentType.CharacterActivities}"));

            if (serializedResponse == null)
                throw Destiny2.requestProcessingErrorResponse;

            return JsonSerializer.Deserialize<DestinyCharacterActivitiesComponent>(serializedResponse, api.SerializerOptions);
        }
    }
}