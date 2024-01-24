using Microsoft.EntityFrameworkCore;
using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Models;

namespace BuscControl.Test
{
    public class TestDatabaseContext : DbContext
    {
        public TestDatabaseContext(DbContextOptions<TestDatabaseContext> options)
            : base(options)
        {
        }

        // Defina as DbSet correspondentes às suas tabelas de banco de dados aqui
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<TripPassengerModel> TripsPassengers { get; set; }
    }
}
