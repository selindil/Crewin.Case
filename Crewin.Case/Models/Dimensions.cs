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
//Dimensions sınıfı, bir nesnenin genişlik, yükseklik ve derinlik özelliklerini JSON formatına uygun şekilde temsil eder. Bu sınıf sayesinde JSON verileri kolayca nesneye dönüştürülebilir veya nesneler JSON formatına çevrilebilir.






