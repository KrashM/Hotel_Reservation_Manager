using System.Linq;

namespace Hotel_Reservation_Manager.Controllers{

    public static class SharedData{

        public static Models.Data.User logged;
        public static System.Collections.Generic.List<Models.Data.Client> ClientList;

        public static int GetRoomNumber(System.Guid room_id){

            using(Models.Context _context = new Models.Context()){

                return _context.Rooms.Find(room_id).Number;

            }

        }

        public static string GetUsernameAppointer(System.Guid appointer_id){

            using(Models.Context _context = new Models.Context()){

                return _context.Users.Find(appointer_id).Username;

            }

        }

        public static System.Collections.Generic.List<Models.Data.Room> GetFreeRooms(){

            using(Models.Context _context = new Models.Context()){
                
                    return _context.Rooms.Where(x => !_context.Reservations.Any(y => (y.RoomID==x.Id) && (y.DateOfAccommodation < System.DateTime.Now) && (y.ReleaseDate > System.DateTime.Now))).ToList();

            }

        }

    }

}