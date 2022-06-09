

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        [Required]
        public string ModelName { get; set; }
        public int CarId { get; set; }
        [Required]
        public int BrandId { get; set; }
        [Required]
        public int ColorId { get; set; }
        [Required]
        public int ModelYear { get; set; }
        [Required]
        public decimal PricePerHour { get; set; }
    }
}
