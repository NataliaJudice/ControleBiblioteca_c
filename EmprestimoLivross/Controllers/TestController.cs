using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivross.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
