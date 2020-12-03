using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace RazorFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }
    }
}