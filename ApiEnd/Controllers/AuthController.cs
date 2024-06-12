using Microsoft.AspNetCore.Mvc;

namespace ApiEnd.Controllers
{  
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    //[RequiredScope(RequiredScopesConfigurationKey ="AzireAd:scopes")]
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
