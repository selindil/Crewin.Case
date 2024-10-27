using Newtonsoft.Json;

namespace Crewin.Case.Models
{
    public class Meta
    {
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("qrCode")]
        public string QrCode { get; set; }
    }
}
