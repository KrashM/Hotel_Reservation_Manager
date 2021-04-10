using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Hotel_Reservation_Manager.Models;
using Hotel_Reservation_Manager.Models.Data;
using System.Linq;

namespace Hotel_Reservation_Manager.Controllers{

    public class ReservationsController : Controller{

        public ActionResult CreateMenu(){

            return View("~/Views/Reservation/Create.cshtml");

        }

        public ActionResult EditMenu(System.Guid user_id){

            using(Context _context = new Context()){

                return View("~/Views/Reservation/Edit.cshtml", _context.Users.Find(user_id));

            }

        }
        
        public ActionResult ShowDetails(System.Guid reservation_id){

            using(Context _context = new Context()){

                return View("~/Views/Reservation/Details.cshtml", _context.Reservations.Find(reservation_id));

            }

        }

        public ActionResult Create(System.Guid roomID, System.Guid idOfAppointer, System.DateTime dateofaccomodation, System.DateTime releaseDate, bool Breakfast, bool AllInclusive, double Price){

            using(Context _context = new Context()){

                Reservation reservation = new Reservation();

                reservation.Id = System.Guid.NewGuid();
                reservation.RoomID = roomID;
                reservation.IDOfAppointer = idOfAppointer;
                foreach(Client client in SharedData.ClientList){

                    ReservationClients newConnection = new ReservationClients();
                    newConnection.Id = System.Guid.NewGuid();
                    newConnection.ReservationID = reservation.Id;
                    newConnection.ClientID = client.Id;

                    _context.ReservationClients.Add(newConnection);

                }
                reservation.DateOfAccommodation = dateofaccomodation;
                reservation.ReleaseDate = releaseDate;
                reservation.Breakfast = Breakfast;
                reservation.AllInclusive = AllInclusive;
                reservation.Price = Price;

                _context.Reservations.Add(reservation);
                _context.SaveChanges();

                return View("~/Views/Platform/Reservations.cshtml", _context.Reservations.ToList());

            }

        }

    }

}