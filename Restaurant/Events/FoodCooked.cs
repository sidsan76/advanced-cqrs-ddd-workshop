﻿using System;
using Restaurant.Models;

namespace Restaurant.Events
{
    public class FoodCooked : Message
    {
        public FoodCooked(OrderDocument order, Guid correlationId, Guid causationId, Guid? id = null) 
            : base(order, correlationId, causationId, id)
        {
        }
    }
}