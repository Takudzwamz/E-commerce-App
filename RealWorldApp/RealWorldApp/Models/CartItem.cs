﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RealWorldApp.Models
{
    public class CartItem
    {
        public double price { get; set; }
        public double totalAmount { get; set; } //Not in new API


        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
    }
}
