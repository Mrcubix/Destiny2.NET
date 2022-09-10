using API.Entities.Destiny;

namespace API.Entities.Characters
{
    public class DestinyCharacterActivitiesComponent
    {
        public DateTime DateActivityStarted { get; set; }
        public DestinyActivity[] AvailableActivities { get; set; }
        public uint CurrentActivityHash { get; set; }
        public uint CurrentActivityModeHash { get; set; }
        public int CurrentActivityModeType { get; set; }
        public uint[] CurrentActivityModeHashes { get; set; }
        public int[] CurrentActivityModeTypes { get; set; }
        public uint? CurrentPlaylistActivityHash { get; set; }
        public uint LastCompletedStoryHash { get; set; }
    }
}