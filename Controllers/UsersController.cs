using Microsoft.AspNetCore.Mvc;
using Hotel_Reservation_Manager.Models;
using Hotel_Reservation_Manager.Models.Data;
using Hash;
using System.Linq;

namespace Hotel_Reservation_Manager.Controllers{

    public class UsersController : Controller{

        public void ShowUsers(){

            System.Console.WriteLine("Hello");

            using(Context _context = new Context()){

                foreach(User user in _context.Users.ToList()){
                    System.Console.WriteLine($"{user.Name} - {user.SirName} - {user.Username}");
                }

            }

        }

    }

}