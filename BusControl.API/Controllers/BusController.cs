using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using global::BusControl.API.DataBase.SqlConnection;
using global::BusControl.API.Interfaces.Repositories;

namespace BusControl.API.Controllers
{
    public class BusController : Controller
    {
        private readonly IBusRepository _busRepository;

        public BusController(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }

        [HttpGet("/buses")]
        public ActionResult<IEnumerable<Bus>> GetBuses()
        {
            var buses = _busRepository.GetBuses();
            return Ok(buses);
        }

        [HttpGet("/buses/{id:int}")]
        public ActionResult<Bus> GetBusById(int id)
        {
            var bus = _busRepository.GetBusById(id);
            if (bus == null)
            {
                return NotFound();
            }

            return Ok(bus);
        }

        [HttpPost("/buses")]
        public ActionResult<Bus> AddBus([FromBody] Bus bus)
        {
            _busRepository.AddBus(bus);
            _busRepository.SaveChanges();

            return bus;
        }

        [HttpPut("/buses/{id:int}")]
        public IActionResult UpdateBus([FromBody] Bus bus, int id)
        {
            var existingBus = _busRepository.GetBusById(id);

            if (existingBus == null)
            {
                return NotFound();
            }

            _busRepository.UpdateBus(bus);
            _busRepository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("/buses/{id:int}")]
        public ActionResult DeleteBus(int id)
        {
            _busRepository.DeleteBus(id);
            _busRepository.SaveChanges();

            return Ok();
        }
    }
 }
