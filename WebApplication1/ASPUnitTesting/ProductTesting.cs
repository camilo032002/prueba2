using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers;
using WebApplication1.Models;
using WebApplication1.service;
using Xunit;

namespace ASPUnitTesting
{
    public class ProductTesting
    {

        private readonly productoController _productoController;
        private readonly ProductService _ProductService;

        public ProductTesting()
        {
            _ProductService = new ProductService();
            _productoController = new productoController(_ProductService);
        }

        [Fact]
        public void Get_ok()
        {
            var result = _productoController.get();

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Get_masDatos()
       {
            var result = (OkObjectResult) _productoController.get();

            var tienda = Assert.IsType<List<tienda>>(result.Value);

            Assert.True(tienda.Count > 0);
       }

    }
}