using Microsoft.EntityFrameworkCore;
using Hotel_Reservation_Manager.Models.Data;

namespace Hotel_Reservation_Manager.Models{

    public class Context : DbContext{

        public Context():base(){}

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=localhost; Database=HotelReservationManager; Integrated Security=true;");
        }

    }

}