﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rapsody.Models
{
    public class RapsodyFoodsItem
    {
        public int Id { get; set; }
        public Food Food { get; set; }
        public double Price { get; set; }
        public string RapsodyFoodId { get; set; }
    }
}
