using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Prince { get; set; }

    }
    public class MovieDBContext : DbContext    //kết nối đến CSDL thông qua MovieDBContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}