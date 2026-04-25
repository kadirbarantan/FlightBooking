using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.ViewComponents.DefaultViewComponents
{
    public class _DefaultTravelPackagesComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
