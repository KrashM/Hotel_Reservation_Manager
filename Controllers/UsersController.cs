using Microsoft.AspNetCore.Mvc;
using Hotel_Reservation_Manager.Models;
using Hotel_Reservation_Manager.Models.Data;
using Hash;
using System.Linq;

namespace Hotel_Reservation_Manager.Controllers{

    public class UsersController : Controller{

        public ActionResult CreateMenu(){

            return View("~/Views/User/Create.cshtml");

        }

        public ActionResult EditMenu(System.Guid user_id){

            using(Context _context = new Context()){

                return View("~/Views/User/Edit.cshtml", _context.Users.Find(user_id));

            }

        }

        public ActionResult Create(string username, string password, string name, string MiddleName, string surname, string PersonalID, string PhoneNumber, string email, System.DateTime DateOfAppointment, bool active, bool Administrator){

            using(Context _context = new Context()){

                User newUser = new User();

                newUser.Id = System.Guid.NewGuid();
                newUser.Username = username;
                newUser.Password = Password_Hasher.Hash(password);
                newUser.Name = name;
                newUser.MiddleName = MiddleName;
                newUser.SurName = surname;
                newUser.PersonalID = PersonalID;
                newUser.PhoneNumber = PhoneNumber;
                newUser.Email = email;
                newUser.DateOfAppointment = DateOfAppointment;
                newUser.Active = active;
                newUser.Administrator = Administrator;

                _context.Users.Add(newUser);
                _context.SaveChanges();

                return View("~/Views/Platform/Users.cshtml", _context.Users.ToList());

            }


        }

        [HttpGet]
        public ActionResult ShowDetails(System.Guid user_id){

            using(Context _context = new Context()){

                return View("~/Views/User/Details.cshtml", _context.Users.Find(user_id));

            }

        }

        public ActionResult EditUser(System.Guid Id, string username, string name, string MiddleName, string surname, string PersonalID, string PhoneNumber, string email, System.DateTime DateOfAppointment, bool active, System.DateTime DateOfDismissal, bool Administrator){

            System.Console.WriteLine(new{username, name, MiddleName, surname, PersonalID, PhoneNumber, email, DateOfAppointment, active, DateOfDismissal, Administrator, Id});

            using(Context _context = new Context()){

                User user = _context.Users.Find(Id);

                user.Username = username;
                user.Name = name;
                user.MiddleName = MiddleName;
                user.SurName = surname;
                user.PersonalID = PersonalID;
                user.PhoneNumber = PhoneNumber;
                user.Email = email;
                user.DateOfAppointment = DateOfAppointment;
                user.Active = active;
                user.DateOfDismissal = DateOfDismissal;
                user.Administrator = Administrator;

                _context.SaveChanges();
            
                return View("~/Views/Platform/Users.cshtml", _context.Users.ToList());

            }


        }

        public ActionResult DeleteUser(System.Guid user_id){

            using(Context _context = new Context()){

                _context.Users.Remove(_context.Users.Find(user_id));
                _context.SaveChanges();

                return View("~/Views/Platform/Users.cshtml", _context.Users.ToList());

            }

        }

    }

}