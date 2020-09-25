﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Movie_App.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Title { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set;}
        public string Tittle { get; set;}
        public string Description { get; set;}
        public int[] Ratings { get; set; }

    }
}
