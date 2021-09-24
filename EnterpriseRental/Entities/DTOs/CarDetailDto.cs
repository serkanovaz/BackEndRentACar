﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public string BrandName { get; set; }
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Fuel { get; set; }
        public string Gear { get; set; }
        public int BrandId { get; set; }
    }
}
