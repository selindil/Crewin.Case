namespace Crewin.Case.Entities
{
    public class Dimensions : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public double depth { get; set; }

    }
}
