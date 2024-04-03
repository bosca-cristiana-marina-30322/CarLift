using Microsoft.AspNetCore.Mvc;
using CarImpundementSystem.Models;

namespace CarImpundementSystem.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult UpdateVehicleStatus(Vehicle vehicle, string status)
        {

            return View();
        }


        public ActionResult ProcessVehicle(Vehicle vehicle)
        {

            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
