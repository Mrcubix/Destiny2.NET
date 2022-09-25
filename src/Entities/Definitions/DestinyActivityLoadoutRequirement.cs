namespace API.Entities.Definitions
{
    public class DestinyActivityLoadoutRequirement : DestinyDefinition
    {
        public uint EquipmentSlotHash { get; set; }
        public uint[] AllowedEquippedItemHashes { get; set; }
        public int[] AllowedWeaponSubTypes { get; set; }
    }
}