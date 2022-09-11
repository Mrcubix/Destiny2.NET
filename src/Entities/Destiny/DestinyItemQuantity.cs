namespace API.Entities
{
    public class DestinyItemQuantity
    {
        public uint ItemHash { get; set; }
        private long _itemInstanceId;
        public string ItemInstanceId
        {
            get => _itemInstanceId.ToString();
            set
            {
                long.TryParse(value, out _itemInstanceId);
            }
        }
        public int Quantity { get; set; }
        public bool HasConditionalVisibility { get; set; }

        public long GetItemInstanceId()
        {
            return _itemInstanceId;
        }

        public void SetItemInstanceId(long id)
        {
            this.ItemInstanceId = id.ToString();
        }
    }
}