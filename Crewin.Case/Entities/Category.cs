namespace Crewin.Case.Entities
{
    public class Category:BaseEntity
    {
        public string slug { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }
}
//Bu sınıf, bir kategori varlığını temsil etmek için kullanılır ve BaseEntity sınıfından kalıtım alarak, temel özellikleri devralır. slug, name ve url gibi özellikleri ile kategoriye dair bilgileri tutar. Bu sınıfın muhtemelen bir veritabanı tablosuyla eşleneceği ve ORM (Object-Relational Mapping) araçlarıyla kullanılacağı öngörülebilir.






