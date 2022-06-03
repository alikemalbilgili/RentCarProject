﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDTos : IDto
    {
        public int CarId { get; set; }
        public string ModelName { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public decimal PricePerHour { get; set; }
        public int ModelYear { get; set; }

    }
}