using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Areas.Admin.Controllers
{
    public class BookingController : Controller
    {
        [Area("Admin")]
        public IActionResult CreateBooking()
        {
            return View();
        }
    }
}
