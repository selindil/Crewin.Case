using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Crewin.Case.Entities
{
    public class Product : BaseEntity
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public decimal Price { get; set; }

        public decimal DiscountPercentage { get; set; }

        public decimal Rating { get; set; }

        public int Stock { get; set; }

        public string Brand { get; set; }

        public string Sku { get; set; }

        public int Weight { get; set; }

        public Dimensions Dimensions { get; set; }

        public Meta Meta { get; set; }

        public string WarrantyInformation { get; set; }
        public string ShippingInformation { get; set; }
        public string AvailabilityStatus { get; set; }

        public string ReturnPolicy { get; set; }
        public int MinimumOrderQuantity { get; set; }

        public string Tags { get; set; }
        public string Images { get; set; }

        public string Thumbnail { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();

        [NotMapped]
        public List<string> TagList
        {
            get => string.IsNullOrWhiteSpace(Tags) ? new List<string>() : new List<string>(Tags.Split(','));
            set => Tags = string.Join(",", value);
        }
        [NotMapped]
        public List<string> ImageList
        {
            get => string.IsNullOrWhiteSpace(Images) ? new List<string>() : new List<string>(Images.Split(','));
            set => Images = string.Join(",", value);
        }

    }
}
