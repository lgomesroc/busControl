using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusControl.API.Models;

namespace BusControl.API.DataBase.SqlConnection
{
    public class BusControlDBContext : DbContext
    {
        public BusControlDBContext(DbContextOptions<BusControlDBContext> options) : base(options)
        {
        }

        public DbSet<Bus> Buses { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<TripPassengerModel> TripsPassengers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public IActionResult NotFound()
        {
            throw new NotImplementedException();
        }

        public IActionResult Ok(object content)
        {
            return Ok(content);
        }

        public IActionResult GetBusIsId(int id)
        {
            var bus = Buses.Find(id);
            if (bus == null)
            {
                return NotFound();
            }
            return Ok(bus);
        }

        public IQueryable<Bus> GetBuses()
        {
            return Buses;
        }

        public void AddBus(Bus bus)
        {
            Buses.Add(bus);
            SaveChanges();
        }

        public void UpdateBus(Bus bus)
        {
            Buses.Update(bus);
            SaveChanges();
        }

        public void DeleteBus(Bus bus)
        {
            Buses.Remove(bus);
            SaveChanges();
        }
    }

    public class Bus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

        public Bus(int id, string name, string origin, string destination)
        {
            Id = id;
            Name = name;
            Origin = origin;
            Destination = destination;
        }

        public Bus(int id, string name, string origin, string destination, string v) : this(id, name, origin, destination)
        {
        }
    }
    public class Driver
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
       

        public Driver(int id, string login, string name, string cpf, string email)
        {
            Id = id;
            Login = login;
            Name = name;
            Cpf = cpf;
            Email = email;
        }

        public Driver(char v1, char v2, char v3, char v4)
        {
        }
    }

    public class Trip
    {
        public int Id { get; set; }
        public int BusId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int Duration { get; set; }
        public int LimitPassengers { get; set; }
        public string Passengers { get; set; }
        public string DriverId { get; set; }
        public Bus Bus { get; set; }
        public Driver Driver { get; set; }

        public Trip(int id, int busId, DateTime departureTime, DateTime arrivalTime, int duration, int limitPassengers, string passengers, string driverId, Bus bus, Driver driver)
        {
            Id = id;
            BusId = busId;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            Duration = duration;
            LimitPassengers = limitPassengers;
            Passengers = passengers;
            DriverId = driverId;
            Bus = bus;
            Driver = driver;
        }

        public Trip(int v1, int v2, DateTime dateTime1, DateTime dateTime2, int v3, int v4, object value, string v5)
        {
        }
    }

    public class Passenger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Passenger(int id, string name, string cpf, string email, string phone)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Email = email;
            Phone = phone;
        }
    }


}