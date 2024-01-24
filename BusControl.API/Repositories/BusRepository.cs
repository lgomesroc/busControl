using BusControl.API.Interfaces.Repositories;
using BusControl.API.DataBase.SqlConnection;

namespace BusControl.API.Repositories
{
    public class BusRepository : IBusRepository
    {
        private readonly BusControlDBContext _context;
        public BusRepository(BusControlDBContext context)
        {
            _context = context;
        }
        public void AddBus(Bus bus)
        {
            _context.Buses.Add(bus);
            _context.SaveChanges();
        }
        public void DeleteBus(int id)
        {
            var bus = _context.Buses.Find(id);
            _context.Buses.Remove(bus);
            _context.SaveChanges();
        }
        public Bus GetBusById(int id)
        {
            return _context.Buses.Find(id);
        }
        public IEnumerable<Bus> GetBuses()
        {
            return _context.Buses.ToList();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public void UpdateBus(Bus bus)
        {
            _context.Buses.Update(bus);
            _context.SaveChanges();
        }

        void IBusRepository.AddBus(Bus bus)
        {
            throw new NotImplementedException();
        }

        void IBusRepository.DeleteBus(int id)
        {
            throw new NotImplementedException();
        }

        Bus IBusRepository.GetBusById(int id)
        {
            throw new NotImplementedException();
        }

        IQueryable<Bus> IBusRepository.GetBuses()
        {
            throw new NotImplementedException();
        }

        void IBusRepository.SaveChanges()
        {
            throw new NotImplementedException();
        }

        void IBusRepository.UpdateBus(Bus bus)
        {
            throw new NotImplementedException();
        }
    }
}
