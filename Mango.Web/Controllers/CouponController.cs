using Microsoft.AspNetCore.Mvc;

namespace Mango.Web.Controllers
{
    public class CouponController : Controller
    {
        public IActionResult CouponIndex()
        {
            return View();
        }
    }
}
