using System.Collections.Generic;
using API.Entities.Response.Base;
using API.Entities.User;

namespace API.Entities.Response
{
    public class PlayerSearchResponse : APIResponse
    {
        public List<UserInfoCard> Response { get; set; }
    }
}