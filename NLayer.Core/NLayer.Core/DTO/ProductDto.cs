﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTO
{
    public class ProductDto:BaseDto
    {
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
    }
}
