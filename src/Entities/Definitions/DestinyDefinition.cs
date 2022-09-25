namespace API.Entities.Definitions
{
    public abstract class DestinyDefinition
    {
        public uint Hash { get; set; }
        public int Index { get; set; }
        public bool Redacted { get; set; }
    }
}