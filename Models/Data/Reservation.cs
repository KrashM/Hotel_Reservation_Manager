namespace Hotel_Reservation_Manager.Models.Data{

    public class Reservation{

        public System.Guid Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public System.Guid RoomID { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public System.Guid IDOfAppointer { get; set; }
        public System.Collections.Generic.ICollection<Client> Clients { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public System.DateTime DateOfAccommodation { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public System.DateTime ReleaseDate { get; set; }
        public bool Breakfast { get; set; }
        public bool AllInclusive { get; set; }
        public double Price { get; set; }


    }

}