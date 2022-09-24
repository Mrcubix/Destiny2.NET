namespace API.Entities.Responses.Base
{
    public class SingleComponentResponseOf<T> 
    {
        public T Data { get; set; }
        public int privacy { get; set; }
        public bool? Disabled { get; set; }
    }
}