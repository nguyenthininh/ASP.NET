using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookWebServiceAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Prodcuct_Name { get; set; }
        public string Context { get; set; }
        public decimal Price { get; set; }

        //Foreign Key
        public int CategoryId { get; set; } 
        public Category Category { get; set; }
    }
}