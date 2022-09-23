namespace API.Entities.Quests
{
    public class DestinyObjectiveProgress
    {
        public uint objectiveHash { get; set; }
        public uint? DestinationHash { get; set; }
        public uint? ActivityHash { get; set; }
        public int Progress { get; set; }
        public int CompletionValue { get; set; }
        public bool Complete { get; set; }
        public bool Visible { get; set; }
    }
}