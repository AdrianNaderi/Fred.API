using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Fred.Models.Entities.SpotEntity
{
    public class ContentEntity
    {
        public int SpotId { get; set; }
        [ForeignKey("SpotId")]
        [ValidateNever]
        public virtual SpotEntity Spot { get; set; }

        public string Titel { get; set; }
        public string Description { get; set; }
        public virtual TagEnity Tag { get; set; }
    }
}
