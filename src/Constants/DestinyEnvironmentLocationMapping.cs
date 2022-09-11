namespace Tracker.API.Constants
{
    public struct DestinyEnvironmentLocationMapping
    {
        // TODO: Map hash to Destiny.Definitions.DestinyLocationDefinition
        public uint LocationHash { get; set; }
        public string  ActivationSource { get; set; }
        // TODO: Map hash to Destiny.Definitions.DestinyInventoryItemDefinition
        public uint? ItemHash { get; set; }
        // TODO: Map hash to Destiny.Definitions.DestinyObjectiveDefinition
        public uint? objectiveHash { get; set; }
        // TODO: Map hash to Destiny.Definitions.DestinyActivityDefinition
        public uint? ActivityHash { get; set; }
    }
}