﻿using System;
using System.Collections.Generic;

#nullable disable

namespace back_end.Entities
{
    public partial class Product
    {
        public string ProductId { get; set; }
        public string Title { get; set; }
        public int? Price { get; set; }
        public string Detail { get; set; }
        public string Img { get; set; }
        public string Category { get; set; }
    }
}
