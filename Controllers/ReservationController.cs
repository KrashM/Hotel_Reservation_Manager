using Microsoft.AspNetCore.Mvc;
using Hotel_Reservation_Manager.Models;

namespace Hotel_Reservation_Manager.Controllers{

    public class ReservationController : Controller{

        public ActionResult CreateMenu(){

            return View("~/Views/Reservation/Create.cshtml");

        }

        public ActionResult EditMenu(System.Guid user_id){

            using(Context _context = new Context()){

                return View("~/Views/Reservation/Edit.cshtml", _context.Users.Find(user_id));

            }

        }
        
    }

}