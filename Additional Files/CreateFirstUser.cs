using Hash;
using System;
using Hotel_Reservation_Manager.Models;
using Hotel_Reservation_Manager.Models.Data;
using System.Linq;

namespace HardCode{

    public static class HardCodeUsers{

        public static void CreateAdmin(){

            using(Context context = new Context()){

                context.Users.Remove(context.Users.ToList()[0]);
                context.SaveChanges();

                User FirstAdmin = new User();

                FirstAdmin.Username = "Krash";
                FirstAdmin.Password = Password_Hasher.Hash("adminpass");
                FirstAdmin.Name = "Hristo";
                FirstAdmin.MiddleName = "Antonov";
                FirstAdmin.SirName = "Kanev";
                FirstAdmin.PersonalID = "0246228524";
                FirstAdmin.PhoneNumber = "0878686974";
                FirstAdmin.Email = "HristoKanevKrash@gmail.com";
                FirstAdmin.DateOfAppointment = DateTime.Now;
                FirstAdmin.Active =  true;
                FirstAdmin.Administrator = true;

                context.Users.ToList().Insert(0, FirstAdmin);
                context.SaveChanges();

            }

        }

    } 

}