using Newtonsoft.Json;

namespace Crewin.Case.Models
{
    public class Product
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("discountPercentage")]
        public double DiscountPercentage { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("stock")]
        public int Stock { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("warrantyInformation")]
        public string WarrantyInformation { get; set; }

        [JsonProperty("shippingInformation")]
        public string ShippingInformation { get; set; }

        [JsonProperty("availabilityStatus")]
        public string AvailabilityStatus { get; set; }

        [JsonProperty("reviews")]
        public List<Review> Reviews { get; set; }

        [JsonProperty("returnPolicy")]
        public string ReturnPolicy { get; set; }

        [JsonProperty("minimumOrderQuantity")]
        public int MinimumOrderQuantity { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("images")]
        public List<string> Images { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }
}
