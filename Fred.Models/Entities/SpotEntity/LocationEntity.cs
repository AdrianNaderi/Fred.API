using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Fred.Models.Entities.SpotEntity
{
    public class LocationEntity
    {
        public int SpotId { get; set; }
        [ForeignKey("SpotId")]
        [ValidateNever]
        public virtual SpotEntity Spot { get; set; }

        public string Address { get; set; }
        public string Area { get; set; }
        public string GooleMapsId { get; set; }
        public int Lat { get; set; }
        public int Lng { get; set; }

    }
}