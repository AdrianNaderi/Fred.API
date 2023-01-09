using System.ComponentModel.DataAnnotations;
using Fred.Models.Entities.Common;

namespace Fred.Models.Entities
{
    public class UserEntity : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}
