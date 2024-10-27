﻿using Newtonsoft.Json;

namespace Crewin.Case.Models
{
    public class ProductResponse
    {
        [JsonProperty("products")]
        public List<Product> Products { get; set; } = new List<Product>();

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}
