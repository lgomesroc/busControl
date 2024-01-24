using BusControl.API.Models;

namespace BusControl.API.Interfaces.Repositories
{
    public interface IDriverRepository
    {
        IQueryable<DriverModel> GetDrivers();
        DriverModel GetDriverById(int id);
        void CreateDriver(DriverModel driver);
        void UpdateDriver(int id, DriverModel driver);
        void DeleteDriver(int id);
    }
}