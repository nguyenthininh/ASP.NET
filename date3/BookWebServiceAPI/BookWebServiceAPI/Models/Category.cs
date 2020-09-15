﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookWebServiceAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Category_Name { get; set; }
    }
}