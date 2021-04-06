namespace Hotel_Reservation_Manager.Models.Data{

    public class Room{

        public System.Guid Id { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }
        public double PriceForBedAdult { get; set; }
        public double PriceForBedChild { get; set; }
        public int Number { get; set; }


    }

}