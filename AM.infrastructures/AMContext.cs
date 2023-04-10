using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.infrastructures.configurations;
using Microsoft.EntityFrameworkCore;


namespace AM.infrastructures
{
    // 1 etape : DbContext
    // 2 etape : installation d'orm : entity framework CORE
    public class AMContext:DbContext
    {
        //3 etape  : les entites 
        //DbSet<Entity> Table 
        // ca va creer table Flights
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<ReservationTicket> ReservationTicket { get; set; }
        // 4 etape : fournir la chaine de connexion ( nom db + nom serveur )
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  je vais utiliser sql 
            // le source local ( pas d utilisation de wamp ou xamp)
            // Catalog= Nom de base de donnés
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
Initial Catalog=AirportManagementBase2;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);







        }
        // 2 commandes pour le lancement et la generation du base 
        //  1 commend : add-migration Nom_mig
        //  2 command update-database
        // install Microsoft.EntityFrameworkCore.tools fl AM.infrast
        // install Microsoft.EntityFrameworkCore.Desdign dans AM.console 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            // equivalente lel fichier.0 PlaneConfiguration 

            modelBuilder.ApplyConfiguration(new FlightConfiguration());

            modelBuilder.Entity<ReservationTicket>().HasKey(p => new
            {
                p.PassengerFk,
                p.TicketFk,
                p.DateReservation
            });
        }

    }
}
