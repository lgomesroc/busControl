using BusControl.API.Models;

namespace BusControl.API.Interfaces.Repositories
{
    public interface ITripPassengerRepository
    {
        IQueryable<TripPassengerModel> GetByTripId(int tripId);
        IQueryable<TripPassengerModel> GetByPassengerId(int passengerId);
        void CreateTripPassenger(TripPassengerModel tripPassenger);
        void DeleteTripPassenger(int tripId, int passengerId);
    }
}
