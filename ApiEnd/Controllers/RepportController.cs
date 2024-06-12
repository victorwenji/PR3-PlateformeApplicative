using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepportController : Controller
    {
        [Authorize("Manager")]
       public IActionResult GetReport() {
            return File(System.IO.File.ReadAllBytes(""), "application/pdf");
        }
    }
}
