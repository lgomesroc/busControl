using Microsoft.AspNetCore.Mvc;
using BusControl.API.Models;
using BusControl.API.Interfaces.Repositories;
using BusControl.API.DataBase.SqlConnection;

namespace BusControl.API.Controllers
{
    [Route("api/passengers")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private readonly IPassengerRepository _passengerRepository;

        public PassengerController(IPassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Passenger>> GetPassengers()
        {
            var passengers = _passengerRepository.GetPassengers();
            return Ok(passengers);
        }

        [HttpGet("{id}")]
        public ActionResult<Passenger> GetPassengerById(int id)
        {
            var passenger = _passengerRepository.GetPassengerById(id);

            if (passenger == null)
            {
                return NotFound();
            }

            return Ok(passenger);
        }

        [HttpPost]
        public ActionResult<Passenger> CreatePassenger([FromBody] Passenger passenger)
        {
            _passengerRepository.CreatePassenger(passenger);
            return Ok(passenger);
        }

        [HttpPut("{id}")]
        public ActionResult<Passenger> UpdatePassenger(int id, [FromBody] Passenger passenger)
        {
            var existingPassenger = _passengerRepository.GetPassengerById(id);

            if (existingPassenger == null)
            {
                return NotFound();
            }

            _passengerRepository.UpdatePassenger(id, passenger);
            return Ok(passenger);
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePassenger(int id)
        {
            var existingPassenger = _passengerRepository.GetPassengerById(id);

            if (existingPassenger == null)
            {
                return NotFound();
            }

            _passengerRepository.DeletePassenger(id);
            return Ok();
        }
    }
}
