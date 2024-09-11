using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication7.models;
using WebApplication7.Services;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        public IProductService _service;
        public ProductAPIController(IProductService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_service.GetAllProducts());
        }


        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product obj = _service.GetProductById(id);

            if (obj == null)
            {
                return NotFound(new { result = "Requested products details are not available in the database." });
            }
            else
            {
                return Ok(obj);
            }
        }


        [HttpPost]
        public IActionResult CreateProduct(Product obj)
        {
            _service.AddProduct(obj);
            return Ok(new { result = "product Details added to database" });
        }


        [HttpPut]
        public IActionResult UpdateProduct(Product productobj)
        {
            _service.UpdateProduct(productobj);
     
            return Ok(new { status = "Product details updated in database." });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            Product obj = _service.GetProductById(id);

            if (obj != null)
            {
                _service.DeleteProduct(obj);
                return Ok(new { status = "Product details are deleted from database." });
            }
            else
            {
                return NotFound(new { status = "Product details does not exists in the database." });
            }
        }

    }
}

   

