namespace Hotel_Reservation_Manager.Models.Data{

    public class User{

        public System.Guid Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Username { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string MiddleName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string SirName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string PersonalID { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Phone]
        public string PhoneNumber { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.EmailAddress]
        public string Email { get; set; }
        public System.DateTime DateOfAppointment { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateOfDismissal { get; set; }
        public bool Administrator { get; set; }


    }

}