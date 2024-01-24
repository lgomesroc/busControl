using BusControl.API.Interfaces;
using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Models;

namespace BusControl.API.Models
{
    public class TripModel : ITrip
    {
        public int Id { get; set; }
        public int BusId { get; set; }
        DateTime DepartureTime { get; set; }
        DateTime ArrivalTime { get; set; }
        public int Duration { get; set; }
        public int LimitPassengers { get; set; }
        public string Passengers { get; set; }
        public int DriverId { get; set; }

        public Bus Bus { get; set; }
        public Driver Driver { get; set; }
        public List<TripPassengerModel> TripPassengers { get; set; }

        int ITrip.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ITrip.BusId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime ITrip.DepartureTieme { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime ITrip.ArrivalTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ITrip.Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ITrip.LimitPassengers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ITrip.Passengers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ITrip.DriverId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public TripModel(int id, int busId, DateTime departureTime, DateTime arrivalTime, int duration, int limitPassengers, string passengers, int driverId)
        {
            int Id = id;
            int BusId = busId;
            DateTime DepartureTime = departureTime;
            DateTime ArrivalTime = arrivalTime;
            int Duration = duration;
            int LimitPassengers = limitPassengers;
            string Passengers = passengers;
            int DriverId = driverId;
        }
    }
}
