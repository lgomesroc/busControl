using BusControl.API.DataBase.SqlConnection;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace BusControl.API.Interfaces.Repositories
{
    public interface IBusRepository
    {
        IQueryable<Bus> GetBuses();
        Bus GetBusById(int id);
        void AddBus(Bus bus);
        void UpdateBus(Bus bus);
        void DeleteBus(int id);
        void SaveChanges();
    }
}
