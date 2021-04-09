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

                dynamic mymodel = new System.Dynamic.ExpandoObject();  
                mymodel.LoggedUser = SharedData.logged;  
                mymodel.Users = _context.Users.ToList();  
                return View("~/Views/Platform/Users.cshtml", mymodel);
                
            }


        }

        public ActionResult Reservations(){

            using(Context _context = new Context()){

                //ViewData["User"]

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
