namespace Hotel_Reservation_Manager.Controllers{

    public static class SharedData{

        public static Hotel_Reservation_Manager.Models.Data.User logged;

        public static int GetRoomID(System.Guid room_id){

            using(Hotel_Reservation_Manager.Models.Context _context = new Hotel_Reservation_Manager.Models.Context()){

                return _context.Rooms.Find(room_id).Number;

            }

        }

    }

}