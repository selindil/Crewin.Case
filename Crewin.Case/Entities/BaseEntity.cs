using System.ComponentModel.DataAnnotations;

namespace Crewin.Case.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        protected BaseEntity()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
//BaseEntity, tüm varlık sınıfları için ortak olan Id ve CreatedAt özelliklerini içeren bir temel sınıftır.
