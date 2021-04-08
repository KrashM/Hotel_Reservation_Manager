using Microsoft.AspNetCore.Mvc;
using Hotel_Reservation_Manager.Models;
using Hotel_Reservation_Manager.Models.Data;
using System.Collections.Generic;
using System.Linq;

namespace Hotel_Reservation_Manager.Controllers
{
    public class PlatformController : Controller
    {

        public ActionResult Users(){

            using(Context _context = new Context()){

                return View("~/Views/Platform/Users.cshtml", _context.Users.ToList());
            }


        }

        public ActionResult Reservations(){

            using(Context _context = new Context()){

                return View("~/Views/Platform/Reservations.cshtml", _context.Reservations.ToList());

            }

        }

        public ActionResult Clients(){

            using(Context _context = new Context()){

                return View("~/Views/Platform/Clients.cshtml", _context.Clients.ToList());
                
            }

        }
    }
}
