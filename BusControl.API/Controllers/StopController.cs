using Microsoft.AspNetCore.Mvc;
using BusControl.API.Interfaces.Repositories;
using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Models;
using BusControl.API.DataBase;

namespace BusControl.API.Controllers
{
    public class StopController : Controller
    {
        private readonly BusControlDBContext _dbContext;

        public StopController(BusControlDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("/stops")]
        public ActionResult<IEnumerable<StopModel>> GetStops()
        {
            return _dbContext.StopContext.ToList();
        }

        [HttpGet("/stops/{id}")]
        public ActionResult<StopModel> GetStopById(int id)
        {
            return _dbContext.StopContext.FirstOrDefault(stop => stop.Id == id);
        }

        [HttpPost("/stops")]
        public ActionResult<StopModel> CreateStop(StopModel stop)
        {
            _dbContext.StopContext.Add(stop);
            _dbContext.SaveChanges();
            return stop;
        }

        [HttpPut("/stops/{id}")]
        public ActionResult<StopModel> UpdateStop(int id, StopModel stop)
        {
            var existingStop = _dbContext.StopContext.FirstOrDefault(stop => stop.Id == id);
            existingStop.Name = stop.Name;
            existingStop.Description = stop.Description;
            existingStop.Address = stop.Address;
            existingStop.Latitude = stop.Latitude;
            existingStop.Longitude = stop.Longitude;
            _dbContext.SaveChanges();
            return existingStop;
        }

        [HttpDelete("/stops/{id}")]
        public ActionResult DeleteStop(int id)
        {
            var stop = _dbContext.StopContext.FirstOrDefault(stop => stop.Id == id);
            _dbContext.StopContext.Remove(stop);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
