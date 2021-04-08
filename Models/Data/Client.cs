namespace Hotel_Reservation_Manager.Models.Data{

    public class Client{

        public System.Guid Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string SirName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Phone]
        public string PhoneNumber { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.EmailAddress]
        public string Email { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public bool Adult { get; set; }
        public System.Collections.Generic.ICollection<Reservation> Reservations { get; set; }


    }

}