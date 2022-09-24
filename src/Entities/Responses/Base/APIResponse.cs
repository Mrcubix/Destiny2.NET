namespace API.Entities.Responses.Base
{
    /** 
     * Something about VoiD saying it's better to have all or one, Something about a Chimera which didn't seem to have anything to do with this
     * Surely i will understand one day, right? Clueless
     * Now if you would like to excuse me, i need to empty my mind of its emptyness
     **/
    public abstract class APIResponse
    {
        public int ErrorCode { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public Dictionary<string, string> MessageData { get; set; }
        public int ThrottleSeconds { get; set; }
    }

    public abstract class APIResponse<T> : APIResponse
    {
        public T Response { get; set; }
    }
}