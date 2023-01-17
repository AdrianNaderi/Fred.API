using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Fred.Models.Entities.Common;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Fred.Models.Entities.SpotEntity
{
    public class SpotEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string NameShort { get; set; }
        public virtual ImageEntity Images { get; set; }

        [Required]
        public virtual ContentEntity Content { get; set; }

        [Required]
        public virtual LocationEntity Location { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public virtual CategoryEntity Category { get; set; }

        [Required]
        public int SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        [ValidateNever]
        public virtual SubCategoryEntity SubCategory { get; set; }
    }
}
