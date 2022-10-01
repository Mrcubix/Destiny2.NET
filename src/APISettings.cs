namespace API
{
    public class APISettings
    {
        public event EventHandler<string> OnKeyChanged;

        private string _key = null!;
        public string Key 
        { 
            get => _key;
            set
            {
                _key = value;
                OnKeyChanged?.Invoke(this, value);
            }
        }
        public string Username { get; set; }
        public short Tag { get; set; }
        public short MaxRetries { get; set; }
    }
}