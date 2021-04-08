using Hash;
using System;
using Hotel_Reservation_Manager.Models;
using Hotel_Reservation_Manager.Models.Data;
using System.Linq;

namespace HardCode{

    public static class HardCodeUsers{

        public static void CreateAdmin(){

            using(Context _context = new Context()){

                User FirstAdmin = new User();

                FirstAdmin.Id = Guid.NewGuid();
                FirstAdmin.Username = "Krash";
                FirstAdmin.Password = Password_Hasher.Hash("adminpass");
                FirstAdmin.Name = "Hristo";
                FirstAdmin.MiddleName = "Antonov";
                FirstAdmin.SurName = "Kanev";
                FirstAdmin.PersonalID = "4568432687";
                FirstAdmin.PhoneNumber = "0878987668";
                FirstAdmin.Email = "HristoKanevKrash@gmail.com";
                FirstAdmin.DateOfAppointment = DateTime.Now;
                FirstAdmin.Active =  true;
                FirstAdmin.Administrator = true;

                _context.Users.Add(FirstAdmin);
                _context.SaveChanges();


            }

        }

    } 

}