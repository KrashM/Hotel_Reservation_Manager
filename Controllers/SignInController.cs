using Microsoft.AspNetCore.Mvc;
using Hotel_Reservation_Manager.Models;
using Hotel_Reservation_Manager.Models.Data;
using Hash;
using System.Linq;

namespace Hotel_Reservation_Manager.Controllers{

    public class SignInController : Controller{

        [HttpPost]
        public ActionResult Verify(string username, string password){

            using(Context _context = new Context()){

                User result = _context.Users.ToList().Find(x => x.Username == username);
                
                if(!Password_Hasher.Verify(password, result.Password) || !result.Active){
                    
                    //TODO: Create Exception
                    return View("~/Views/Home/Index.cshtml");

                }
                
                SharedData.logged = result;

                return View("Home");
            
            }


        }

    }

}