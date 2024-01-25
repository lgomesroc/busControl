using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Models;

namespace BusControl.API.Interfaces.Repositories
{
    public interface ITripRepository
    {
        IQueryable<TripModel> GetTrips();
        TripModel GetTripById(int id);
        void CreateTrip(TripModel trip);
        void UpdateTrip(int id, TripModel trip);
        void DeleteTrip(int id);
        void CreateRoute(TripModel trip);
        void UpdateTrip(int id, Trip trip);
        void CreateTrip(Trip trip);
    }
}


