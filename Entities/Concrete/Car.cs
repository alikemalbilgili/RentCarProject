

using Core.Entities;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public string ModelName { get; set; }
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal PricePerHour { get; set; }
    }
}
