using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Fred.Models.Entities.SpotEntity
{
    public class ImageEntity
    {
        public int SpotId { get; set; }
        [ForeignKey("SpotId")]
        [ValidateNever]
        public virtual SpotEntity Spot { get; set; }

        public string[] Images { get; set; }
        public string Icon { get; set; }

    }
}
