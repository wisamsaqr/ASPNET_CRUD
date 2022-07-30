using Microsoft.AspNetCore.Mvc;
using Tsak.Dtos;
using Tsak.Services;

namespace Tsak.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(productService.GetAll());
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(productService.Get(id));
        }

        [HttpPost]
        public IActionResult Create(CreateProductDto createProductDto)
        {
            return Ok(productService.Create(createProductDto));
        }

        [HttpPut]
        public IActionResult Edit(EditProductDto editProductDto)
        {
            return Ok(productService.Edit(editProductDto));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(productService.Delete(id));
        }
    }
}