using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.service;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class productoController : ControllerBase
    {
        private readonly IProduct _productService;

        public productoController(IProduct productService)
        {
            _productService = productService;
        }

        [HttpGet]

        public IActionResult get() => Ok(_productService.get());

        [HttpGet("(id)")]
        public IActionResult GetById(int id)
        {
            var producto = _productService.get(id);

            if(producto == null)
                return NotFound();


            return Ok(producto);
        }
    }
}
