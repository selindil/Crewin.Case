namespace Crewin.Case.Entities
{
    public class Meta : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime updatedAt { get; set; }
        public string barcode { get; set; }
        public string qrCode { get; set; }
    }
}
