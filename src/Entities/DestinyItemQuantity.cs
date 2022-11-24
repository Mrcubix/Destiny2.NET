namespace API.Entities
{
    public class DestinyItemQuantity
    {
        public uint ItemHash { get; set; }
        public long ItemInstanceId { get; set; }
        public int Quantity { get; set; }
        public bool HasConditionalVisibility { get; set; }
    }
}