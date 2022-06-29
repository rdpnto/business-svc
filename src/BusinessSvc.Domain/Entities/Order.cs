﻿using BusinessSvc.Domain.Enums;
using System;

namespace BusinessSvc.Domain.Entities
{
    public class Order
    {
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderStatus Status { get; set; }
    }
}
