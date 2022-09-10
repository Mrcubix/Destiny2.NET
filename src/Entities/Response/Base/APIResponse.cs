using System.Collections.Generic;

namespace API.Entities.Response.Base
{
    public class APIResponse
    {
        public int ErrorCode { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public Dictionary<string, string> MessageData { get; set; }
        public int ThrottleSeconds { get; set; }
    }
}