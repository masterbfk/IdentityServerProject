using IdentityServer.API2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.API2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PicturesController : Controller
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetPicture()
        {
            var list = new List<Picture>()
            {
                new Picture(){Id = 1, Name = "at",Url="at.jpg"},
                new Picture(){Id = 2, Name = "kedi",Url="kedi.jpg"},
                new Picture(){Id = 3, Name = "köpek",Url="köpek1.jpg"},
                new Picture(){Id = 4, Name = "ayı",Url="ayı.jpg"}
            };
            return Ok(list);
        }
    }
}
