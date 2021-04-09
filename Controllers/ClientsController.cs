using Microsoft.AspNetCore.Mvc;
using Hotel_Reservation_Manager.Models;
using Hotel_Reservation_Manager.Models.Data;
using System.Linq;

namespace Hotel_Reservation_Manager.Controllers{

    public class ClientsController : Controller{

        public ActionResult CreateMenu(){

            return View("~/Views/Client/Create.cshtml");

        }

        public ActionResult EditMenu(System.Guid client_id){

            using(Context _context = new Context()){

                return View("~/Views/Client/Edit.cshtml", _context.Clients.Find(client_id));

            }

        }

        public ActionResult Create(string name, string surname, string PhoneNumber, string email, bool Adult){

            using(Context _context = new Context()){

                Client newClient= new Client();

                newClient.Id = System.Guid.NewGuid();
                newClient.Name = name;
                newClient.SurName = surname;
                newClient.PhoneNumber = PhoneNumber;
                newClient.Email = email;
                newClient.Adult = Adult;

                _context.Clients.Add(newClient);
                _context.SaveChanges();

                return View("~/Views/Platform/Clients.cshtml", _context.Clients.ToList());

            }


        }

        public ActionResult ShowDetails(System.Guid client_id){

            using(Context _context = new Context()){

                return View("~/Views/Client/Details.cshtml", _context.Clients.Find(client_id));

            }

        }

        public ActionResult EditClient(System.Guid Id, string name, string surname, string PhoneNumber, string email, bool Adult){

            using(Context _context = new Context()){

                Client client = _context.Clients.Find(Id);

                client.Name = name;
                client.SurName = surname;
                client.PhoneNumber = PhoneNumber;
                client.Email = email;
                client.Adult = Adult;

                _context.SaveChanges();

                return View("~/Views/Platform/Clients.cshtml", _context.Clients.ToList());

            }


        }

        public ActionResult DeleteClient(System.Guid client_id){

            using(Context _context = new Context()){

                _context.Clients.Remove(_context.Clients.Find(client_id));
                _context.SaveChanges();

                return View("~/Views/Platform/Clients.cshtml", _context.Clients.ToList());

            }

        }

    }

}