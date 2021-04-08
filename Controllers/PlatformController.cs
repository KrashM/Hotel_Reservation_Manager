using Microsoft.AspNetCore.Mvc;
using Hotel_Reservation_Manager.Models;
using Hotel_Reservation_Manager.Models.Data;
using System.Linq;

namespace Hotel_Reservation_Manager.Controllers
{
    public class PlatformController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Users(){
            
            System.Console.WriteLine("Hello");

            using(Context _context = new Context()){

                foreach(User user in _context.Users.ToList()){
                    System.Console.WriteLine($"{user.Name} - {user.SirName} - {user.Username}");
                }

            }

            return View("~/Views/Platform/Users.cshtml");

        }

        public ActionResult Reservations(){

            return View("~/Views/Platform/Reservations.cshtml");

        }

        public ActionResult Clients(){

            return View("~/Views/Platform/Clients.cshtml");

        }
    }
}
