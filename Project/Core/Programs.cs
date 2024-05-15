using Newtonsoft.Json;

namespace Project.Core
{
    public class Programs
    {
        [JsonProperty("programID")]
        public string programID { get; set; }

        [JsonProperty("programName")]
        public string programName { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("createdDate")]
        public DateTime createdDate { get; set; }

        [JsonProperty("createdBy")]
        public string createdBy { get; set; }

        [JsonProperty("availableSeates")]
        public int availableSeats { get; set; }
    }
}

