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

        public IQueryable<TripModel> GetTrips()
        {
            throw new NotImplementedException();
        }

        public void CreateRoute(TripModel trip)
        {
            throw new NotImplementedException();
        }

        public void DeleteTrip(int id)
        {
            throw new NotImplementedException();
        }

        public TripModel GetTripById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TripModel> GetTripsForId(int id)
        {
            throw new NotImplementedException();
        }

        IQueryable<TripModel> ITripRepository.GetTrips()
        {
            throw new NotImplementedException();
        }

        TripModel ITripRepository.GetTripById(int id)
        {
            throw new NotImplementedException();
        }

        void ITripRepository.CreateRoute(TripModel trip)
        {
            throw new NotImplementedException();
        }

        void ITripRepository.UpdateTrip(int id, TripModel trip)
        {
            throw new NotImplementedException();
        }

        void ITripRepository.DeleteTrip(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TripModel> GetTr;
    }
}
