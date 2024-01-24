using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Interfaces.Repositories;
using BusControl.API.Models;

namespace BusControl.API.Repositories
{
    public class TripPassengerRepository : ITripPassengerRepository
    {
        private readonly BusControlDBContext _context;

        public TripPassengerRepository(BusControlDBContext context)
        {
            _context = context;
        }

        public IQueryable<TripPassengerModel> GetTrips(int id)
        {
            throw new NotImplementedException();
        }

        public TripPassengerModel GetTripPassengerById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateTripPassenger(TripPassengerModel tripPassenger)
        {
            throw new NotImplementedException();
        }

        public void UpdateTripPassenger(int id, TripPassengerModel tripPassenger)
        {
            throw new NotImplementedException();
        }

        public void DeleteTripPassenger(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TripPassengerModel> GetByTripId(int tripId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TripPassengerModel> GetByPassengerId(int passengerId)
        {
            throw new NotImplementedException();
        }

        public void DeleteTripPassenger(int tripId, int passengerId)
        {
            throw new NotImplementedException();
        }
    }
}



