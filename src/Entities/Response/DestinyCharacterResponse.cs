using API.Entities.Characters;
using API.Entities.Components.Profiles;
using API.Entities.Profiles;
using API.Entities.Response.Base;

namespace API.Entities.Response
{
    public class DestinyCharacterResponse
    {
        // TODO: Implement DestinyInventoryComponent
        public SingleComponentResponseOf<object> Inventory { get; set; }
        // TODO: Implement DestinyPresentationNodesComponent
        public SingleComponentResponseOf<DestinyCharacterComponent> Characters { get; set; }
        // TODO: Implement DestinyCharacterProgressionComponent
        public SingleComponentResponseOf<object> Progressions { get; set; }
        // TODO: Implement DestinyCharacterRenderComponent
        public SingleComponentResponseOf<object> RenderData { get; set; }
        // TODO: Implement DestinyCharacterActivitiesComponent
        public SingleComponentResponseOf<DestinyCharacterActivitiesComponent> Activities { get; set; }
        // TODO: Implement DestinyInventoryComponent
        public SingleComponentResponseOf<object> Equipment { get; set; }
        // TODO: Implement DestinyKiosksComponent
        public SingleComponentResponseOf<object> Kiosks { get; set; }
        // TODO: Implement DestinyPlugSetsComponent
        public SingleComponentResponseOf<object> PlugSets { get; set; }
        // TODO: DestinyPresentationNodesComponent
        public SingleComponentResponseOf<object> PresentationNodes { get; set; }
        // TODO: Implement DestinyCharacterRecordsComponent
        public SingleComponentResponseOf<object> Records { get; set; }
        // TODO: Implement DestinyCollectiblesComponent
        public SingleComponentResponseOf<object> Collectibles { get; set; }
        // TODO: Implement DestinyItemComponentSetOfint64
        public object ItemComponents { get; set; }
        // TODO: Implement DestinyBaseItemComponentSetOfuint32
        public object UninstancedItemComponents { get; set; }
        // TODO: Implement DestinyCurrenciesComponent
        public SingleComponentResponseOf<object> CurrencyLookups { get; set; }
    }
}