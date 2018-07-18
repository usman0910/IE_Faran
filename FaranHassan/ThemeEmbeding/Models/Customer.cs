﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThemeEmbeding.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }

    }
}