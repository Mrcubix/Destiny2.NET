namespace API.Entities.Definitions
{
    public static class DestinyRaceDefinition
    {
        public static Dictionary<int, string> RaceTable { get; set; } = new()
        {
            [0] = "Human",
            [1] = "Awoken",
            [2] = "Exo",
            [3] = "Unknown"
        };
    }
}