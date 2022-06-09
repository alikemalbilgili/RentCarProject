

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public int ColorId { get; set; }
        [Required]
        public string ColorName { get; set; }
    }
}
