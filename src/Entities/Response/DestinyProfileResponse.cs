using API.Entities.Characters;
using API.Entities.Components.Profiles;
using API.Entities.Profiles;
using API.Entities.Response.Base;

namespace API.Entities.Response
{
    public class DestinyProfileResponse
    {
        // TODO: Implement DestinyVendorReceiptsComponent
        public SingleComponentResponseOf<object> VendorReceipts { get; set; }
        // TODO: Implement DestinyInventoryComponent
        public SingleComponentResponseOf<object> ProfileInventory { get; set; }
        // TODO: Implement DestinyCurrenciesComponent
        public SingleComponentResponseOf<object> profileCurrencies { get; set; }
        public SingleComponentResponseOf<DestinyProfileComponent> Profile { get; set; }
        // TODO: Implement DestinyPlatformSilverComponent
        public SingleComponentResponseOf<object> PlatformSilver { get; set; }
        // TODO: Implement DestinyKiosksComponent
        public SingleComponentResponseOf<object> ProfileKiosks { get; set; }
        // TODO: Implement DestinyPlugSetsComponent
        public SingleComponentResponseOf<object> ProfilePlugSets { get; set; }
        public SingleComponentResponseOf<DestinyProfileProgressionComponent> ProfileProgression { get; set; }
        // TODO: Implement DestinyPresentationNodesComponent
        public SingleComponentResponseOf<object> ProfilePresentationNodes { get; set; }
        // TODO: Implement DestinyProfileRecordsComponent
        public SingleComponentResponseOf<object> ProfileRecords { get; set; }
        // TODO: Implement DestinyProfileCollectiblesComponent 
        public SingleComponentResponseOf<object> ProfileCollectibles { get; set; }
        // TODO: Implement DestinyProfileTransitoryComponent 
        public SingleComponentResponseOf<object> ProfileTransitoryData { get; set; }
        // TODO: Implement DestinyMetricsComponent 
        public SingleComponentResponseOf<object> Metrics { get; set; }
        // TODO: Implement DestinyStringVariablesComponent
        public SingleComponentResponseOf<object> ProfileStringVariables { get; set; }
        public SingleComponentResponseOf<Dictionary<long, DestinyCharacterComponent>> Characters { get; set; }
        // TODO: Implement DestinyInventoryComponent
        public SingleComponentResponseOf<Dictionary<long, object>> CharacterInventories { get; set; }
        // TODO: Implement DestinyCharacterProgressionComponent
        public SingleComponentResponseOf<Dictionary<long, object>> CharacterProgressions { get; set; }
        // TODO: Implement DestinyCharacterRenderComponent 
        public SingleComponentResponseOf<Dictionary<long, object>> CharacterRenderData { get; set; }
        // TODO: Implement DestinyCharacterActivitiesComponent
        public SingleComponentResponseOf<Dictionary<long, DestinyCharacterActivitiesComponent>> CharacterActivities { get; set; }
        // TODO: Implement DestinyInventoryComponent
        public SingleComponentResponseOf<Dictionary<long, object>> CharacterEquipment { get; set; }
        // TODO: Implement DestinyKiosksComponent 
        public SingleComponentResponseOf<Dictionary<long, object>> CharacterKiosks { get; set; }
        // TODO: Implement DestinyPlugSetsComponent 
        public SingleComponentResponseOf<Dictionary<long, object>> CharacterPlugSets { get; set; }
        // TODO: Implement DestinyBaseItemComponentSetOfuint32
        public Dictionary<long, object> CharacterUninstancedItemComponents { get; set; }
        // TODO: DestinyPresentationNodesComponent
        public SingleComponentResponseOf<Dictionary<long, object>> CharacterPresentationNodes { get; set; }
        // TODO: Implement DestinyCharacterRecordsComponent
        public SingleComponentResponseOf<Dictionary<long, object>> CharacterRecords { get; set; }
        // TODO: Implement DestinyCollectiblesComponent
        public SingleComponentResponseOf<Dictionary<long, object>> CharacterCollectibles { get; set; }
        // TODO: Implement DestinyStringVariablesComponent
        public SingleComponentResponseOf<Dictionary<long, object>> CharacterStringVariables { get; set; }
        // TODO: DestinyCraftablesComponent
        public SingleComponentResponseOf<Dictionary<long, object>> CharacterCraftables { get; set; }
        // TODO: Implement DestinyItemComponentSetOfint64
        public SingleComponentResponseOf<object> ItemComponents { get; set; }
        // TODO: Implement DestinyCurrenciesComponent
        public SingleComponentResponseOf<Dictionary<long, object>> CharacterCurrencyLookups { get; set; }
    }
}