using System.ComponentModel.DataAnnotations;

namespace Fred.Models.Entities.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
