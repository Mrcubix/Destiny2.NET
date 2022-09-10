using API.Enums;

namespace API.Entities.Response.Base
{
    public class ComponentResponse : APIResponse
    {
        public DestinyComponentType Component { get; }
    }
}