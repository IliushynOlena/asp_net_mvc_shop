﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class User : IdentityUser
    {
        public DateTime Birthdate { get; set; }
        //add orders
        public ICollection<Order> Orders { get; set; }


    }
}
