using Microsoft.AspNetCore.Mvc;
using CarImpundementSystem.Models;

namespace CarImpundementSystem.Controllers
{
    public class WorkerController : Controller
    {
        public ActionResult RegisterPoundedVehicle(Vehicle vehicle)
        {

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
