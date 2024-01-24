using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Interfaces.Repositories;
using BusControl.API.Models;

namespace BusControl.API.Repositories
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly BusControlDBContext _context;

        public PassengerRepository(BusControlDBContext context)
        {
            _context = context;
        }

        public IQueryable<PassengerModel> GetPassengers()
        {
            throw new NotImplementedException();
        }

        public PassengerModel GetPassengerById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreatePassenger(PassengerModel passenger)
        {
            throw new NotImplementedException();
        }

        public void UpdatePassenger(int id, PassengerModel passenger)
        {
            throw new NotImplementedException();
        }

        public void DeletePassenger(int id)
        {
            throw new NotImplementedException();
        }

        IQueryable<Passenger> IPassengerRepository.GetPassengers()
        {
            throw new NotImplementedException();
        }

        Passenger IPassengerRepository.GetPassengerById(int id)
        {
            throw new NotImplementedException();
        }

        void IPassengerRepository.CreatePassenger(Passenger passenger)
        {
            throw new NotImplementedException();
        }

        void IPassengerRepository.UpdatePassenger(int id, Passenger passenger)
        {
            throw new NotImplementedException();
        }

        void IPassengerRepository.DeletePassenger(int id)
        {
            throw new NotImplementedException();
        }
    }
}

