using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Fred.Models.Entities.SpotEntity
{
    public class CategoryEntity
    {
        [Key]
        public string Category { get; set; }
        public string Image { get; set; }


        [ValidateNever]
        public virtual ICollection<SpotEntity> Spots { get; }
        [ValidateNever]
        public virtual ICollection<SubCategoryEntity> SubCategories { get; }
    }
}