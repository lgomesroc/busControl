using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Interfaces.Repositories;
using BusControl.API.Models;
using System;
using System.Linq;

namespace BusControl.API.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        private readonly BusControlDBContext _context;

        public DriverRepository(BusControlDBContext context)
        {
            _context = context;
        }

        public IQueryable<DriverModel> GetDrivers()
        {
            return _context.Drivers.Select(d => new DriverModel(
                d.Id,
                d.Login,
                d.Name,
                d.Cpf,
                d.Email
            ));
        }

        public DriverModel GetDriverById(int id)
        {
            var driver = _context.Drivers.Find(id);
            return driver != null
                ? new DriverModel(driver.Id, driver.Login, driver.Name, driver.Cpf, driver.Email)
                : null;
        }

        public void CreateDriver(DriverModel driver)
        {
            int newId = GenerateId(); // Implemente a lógica de geração de ID
            var newDriverEntity = new Driver(newId, driver.Login, driver.Name, driver.Cpf, driver.Email);

            _context.Drivers.Add(newDriverEntity);
            _context.SaveChanges();
        }

        public void UpdateDriver(int id, DriverModel driver)
        {
            var dbDriver = _context.Drivers.Find(id);
            if (dbDriver != null)
            {
                dbDriver.Name = driver.Name;
                dbDriver.Login = driver.Login;
                dbDriver.Cpf = driver.Cpf;
                dbDriver.Email = driver.Email;

                _context.SaveChanges();
            }
        }

        public void DeleteDriver(int id)
        {
            var driver = _context.Drivers.Find(id);
            if (driver != null)
            {
                _context.Drivers.Remove(driver);
                _context.SaveChanges();
            }
        }
        private int _idCounter = 1;
        private int GenerateId()
        {
            return _idCounter++;
        }
    }
}


