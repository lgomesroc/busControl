using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Interfaces;

namespace BusControl.API.Models
{
    public class TripPassengerModel : ITripPassengers
    {
        public int TripId { get; set; }
        public int PassengerId { get; set; }

        public Trip Trip { get; set; }
        public Passenger Passenger { get; set; }

        public TripPassengerModel(int tripId, int passengerId)
        {
            int TripId = tripId;
            int PassengerId = passengerId;
        }
    }
}
