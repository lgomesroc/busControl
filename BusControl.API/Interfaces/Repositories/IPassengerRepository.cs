using BusControl.API.DataBase.SqlConnection;

namespace BusControl.API.Interfaces.Repositories
{
    public interface IPassengerRepository
    {
        IQueryable<Passenger> GetPassengers();
        Passenger GetPassengerById(int id);
        void CreatePassenger(Passenger passenger);
        void UpdatePassenger(int id, Passenger passenger);
        void DeletePassenger(int id);
    }
}