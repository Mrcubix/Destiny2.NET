namespace API.Entities.Definitions
{
    public class DestinyActivityPlaylistItemDefinition
    {
        public uint ActivityHash { get; set; }
        // TODO: Map hash to Destiny.Definitions.DestinyActivityModeDefinition
        public uint? directActivityModeHash { get; set; }
        public int? directActivityModeType { get; set; }
        // TODO: Map hashes to Destiny.Definitions.DestinyActivityModeDefinition
        public uint[] ActivityModeHashes { get; set; }
        public int[] ActivityModeTypes { get; set; }
    }
}