using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Education.Models;
using Education.Services;
using Microsoft.AspNetCore.Mvc;

namespace Education.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProductsController : ControllerBase
    {
       public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string ProductId,
            [FromQuery] int Rating)
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();  //là một dạng tập hợp các kết quả
        }



    }
}
