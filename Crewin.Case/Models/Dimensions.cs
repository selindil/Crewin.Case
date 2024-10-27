using Newtonsoft.Json;

namespace Crewin.Case.Models
{
    public class Dimensions
    {
        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("depth")]
        public double Depth { get; set; }
    }
}
