namespace Crewin.Case.Entities
{
    public class Review : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int rating { get; set; }
        public string comment { get; set; }
        public DateTime date { get; set; }
        public string reviewerName { get; set; }
        public string reviewerEmail { get; set; }
    }
}
