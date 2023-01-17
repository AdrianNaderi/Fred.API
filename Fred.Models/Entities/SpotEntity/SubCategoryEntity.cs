using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Fred.Models.Entities.SpotEntity
{
    public class SubCategoryEntity
    {
        [Key]
        public string SubCategory { get; set; }
        public string Image { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [ValidateNever]
        [ForeignKey("CategoryId")]
        public virtual CategoryEntity Categories { get; set; }


        [ValidateNever]
        public virtual ICollection<SpotEntity> Spots { get; }
    }
}
