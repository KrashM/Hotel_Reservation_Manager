using Microsoft.AspNetCore.Mvc;
using Hotel_Reservation_Manager.Models;
using Hash;
using System.Linq;

namespace Hotel_Reservation_Manager.Controllers{

    public class SignInController : Controller{

        [HttpPost]
        public ActionResult Verify(string username, string password){

            using(Context _context = new Context()){
                
                if(!Password_Hasher.Verify(password, _context.Users.ToList().Find(x => x.Username == username).Password)){
                    
                    //TODO: Create Exception
                    return View("~/Views/Home/Index.cshtml");

                }
                
            }

            return View("Home");

        }

    }

}