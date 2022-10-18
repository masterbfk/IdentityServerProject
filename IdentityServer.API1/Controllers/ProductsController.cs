using IdentityServer.API1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.API1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : Controller
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetProducts()
        {
            var productList = new List<Product>()
            {
                new Product { Id=1, Name="kalem",Price=100,Stock=1000 },
                new Product { Id=2, Name="silgi",Price=100,Stock=1000 },
                new Product { Id=3, Name="kitap",Price=100,Stock=1000 },
                new Product { Id=4, Name="defte",Price=100,Stock=1000 },
                new Product { Id=5, Name="cetve",Price=100,Stock=1000 },
            };
            return Ok(productList);
        }
    }
}
