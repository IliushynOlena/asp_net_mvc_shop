﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public partial class Cart
    {
        public int Id { get; set; }
    }

    public partial class Cart
    {
        public ICollection<Product> Products { get; set; }
    }
}
