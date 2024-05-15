
using Newtonsoft.Json;

namespace Project.Core
{
    public class Candidate
    {
        [JsonProperty("candidateID")]
        public string candidateID { get; set; }

        [JsonProperty("firstName")]
        public string firstName { get; set; }

        [JsonProperty("lastName")]
        public string lastName { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("phoneNo")]
        public string phoneNo { get; set; }

        [JsonProperty("nationality")]
        public string nationality { get; set; }

        [JsonProperty("currentResidence")]
        public string currentResidence { get; set; }

        [JsonProperty("idNumber")]
        public string idNumber { get; set; }

        [JsonProperty("dateOfBirth")]
        public DateTime dateOfBirth { get; set; }

        [JsonProperty("gender")]
        public string gender { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("graduationYear")]
        public DateTime graduationYear { get; set; }

        [JsonProperty("rejectedByEmbassy")]
        public bool rejectedByEmbassy { get; set; }

        [JsonProperty("yearsOfExperience")]
        public int yearsOfExperience { get; set; }

        [JsonProperty("movemantDate")]
        public DateTime movemantDate { get; set; }
    }
}
