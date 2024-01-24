using BusControl.API.Models;

namespace BusControl.API.Interfaces.Repositories
{
    public interface ITripRepository
    {
        IQueryable<TripModel> GetTrips();
        TripModel GetTripById(int id);
        void CreateRoute(TripModel trip);
        void UpdateTrip(int id, TripModel trip);
        void DeleteTrip(int id);
    }
}
