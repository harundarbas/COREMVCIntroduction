using Microsoft.AspNetCore.Mvc;

namespace COREMVCIntroduction.Controllers
{
    public class DenemeController:Controller
    {
        public IActionResult Index()
        { 
            return View(); 
        }
    }
}
