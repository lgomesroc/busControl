using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Interfaces.Repositories;
using BusControl.API.Models;

namespace BusControl.API.Repositories
{
    public class TripRepository : ITripRepository
    {
        private readonly BusControlDBContext _context;

        public TripRepository(BusControlDBContext context)
        {
            _context = context;
        }

        public TripRepository()
        {
        }

        public IQueryable<TripModel> GetTrips()
        {
            throw new NotImplementedException();
        }

        public TripModel GetTripById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateTrip(TripModel trip)
        {
            throw new NotImplementedException();
        }

        public void UpdateTrip(int id, TripModel trip)
        {
            throw new NotImplementedException();
        }

        public void DeleteTrip(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateRoute(TripModel trip)
        {
            throw new NotImplementedException();
        }

        void ITripRepository.UpdateTrip(int id, Trip trip)
        {
            throw new NotImplementedException();
        }

        void ITripRepository.CreateTrip(Trip trip)
        {
            throw new NotImplementedException();
        }
    }
}

