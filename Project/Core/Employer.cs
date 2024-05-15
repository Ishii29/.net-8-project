using Newtonsoft.Json;

namespace Project.Core
{
    public class Employer
    {
        [JsonProperty("employerID")]
        public string employerID { get; set; }

        [JsonProperty("employerName")]
        public string employerName { get; set; }

        [JsonProperty("department")]
        public string department { get; set; }

        [JsonProperty("roleID")]
        public string roleID { get; set; }
    }
}
