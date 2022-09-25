namespace API.Entities.Definitions
{
    public static class DestinyClassDefinition
    {
        public static Dictionary<int, string> ClassTable { get; set; } = new()
        {
            [0] = "Titan",
            [1] = "Hunter",
            [2] = "Warlock",
            [3] = "Unknown"
        };
    }
}