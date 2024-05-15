using Newtonsoft.Json;

namespace Project.Core
{
    public class Roles
    {
        [JsonProperty("roleID")]
        public string roleID { get; set; }

        [JsonProperty("roleName")]
        public string roleName { get; set; }

       
    }
}
