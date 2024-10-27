using Newtonsoft.Json;

namespace Crewin.Case.Models
{
    public class Review
    {
        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("reviewerName")]
        public string ReviewerName { get; set; }

        [JsonProperty("reviewerEmail")]
        public string ReviewerEmail { get; set; }
    }
}
