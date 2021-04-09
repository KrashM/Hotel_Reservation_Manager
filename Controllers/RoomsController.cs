using Microsoft.AspNetCore.Mvc;
using Hotel_Reservation_Manager.Models;
using Hotel_Reservation_Manager.Models.Data;
using System.Linq;

namespace Hotel_Reservation_Manager.Controllers{

    public class RoomsController : Controller{

        public ActionResult CreateMenu(){

            return View("~/Views/Room/Create.cshtml");

        }

        public ActionResult EditMenu(System.Guid room_id){

            using(Context _context = new Context()){

                return View("~/Views/Room/Edit.cshtml", _context.Rooms.Find(room_id));

            }

        }

        public ActionResult Create(int number, int Capacity, string type, double PriceForBedAdult, double PriceForBedChild){

            using(Context _context = new Context()){

                Room newRoom = new Room();

                newRoom.Id = System.Guid.NewGuid();
                newRoom.Number = number;
                newRoom.Capacity = Capacity;
                newRoom.Type = type;
                newRoom.PriceForBedAdult = PriceForBedAdult;
                newRoom.PriceForBedChild = PriceForBedChild;

                _context.Rooms.Add(newRoom);
                _context.SaveChanges();

                dynamic mymodel = new System.Dynamic.ExpandoObject();
                mymodel.LoggedUser = SharedData.logged;
                mymodel.Rooms = _context.Rooms.ToList();
                return View("~/Views/Platform/Rooms.cshtml", mymodel);

            }


        }

        public ActionResult ShowDetails(System.Guid room_id){

            using(Context _context = new Context()){

                return View("~/Views/Room/Details.cshtml", _context.Rooms.Find(room_id));

            }

        }

        public ActionResult EditRoom(System.Guid Id, int Number, int Capacity, string type, double PriceForBedAdult, double PriceForBedChild){

            using(Context _context = new Context()){

                Room room = _context.Rooms.Find(Id);

                room.Number = Number;
                room.Capacity = Capacity;
                room.Type = type;
                room.PriceForBedAdult = PriceForBedAdult;
                room.PriceForBedChild = PriceForBedChild;

                _context.SaveChanges();

                dynamic mymodel = new System.Dynamic.ExpandoObject();
                mymodel.LoggedUser = SharedData.logged;
                mymodel.Rooms = _context.Rooms.ToList();
                return View("~/Views/Platform/Rooms.cshtml", mymodel);

            }


        }

        public ActionResult DeleteRoom(System.Guid room_id){

            using(Context _context = new Context()){

                _context.Rooms.Remove(_context.Rooms.Find(room_id));
                _context.SaveChanges();

                dynamic mymodel = new System.Dynamic.ExpandoObject();
                mymodel.LoggedUser = SharedData.logged;
                mymodel.Rooms = _context.Rooms.ToList();
                return View("~/Views/Platform/Rooms.cshtml", mymodel);

            }

        }

    }

}