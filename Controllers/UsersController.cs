using Microsoft.AspNetCore.Mvc;
using Hotel_Reservation_Manager.Models;
using Hotel_Reservation_Manager.Models.Data;
using Hash;
using System.Linq;

namespace Hotel_Reservation_Manager.Controllers{

    public class UsersController : Controller{

        public ActionResult Create(){

            return View("~/Views/User/Create.cshtml");

        }

    }

}