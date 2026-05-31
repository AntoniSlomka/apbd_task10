using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apbdtask10_v2.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize]
        public IActionResult Home()
        {
            return View();
        }
    }
}
