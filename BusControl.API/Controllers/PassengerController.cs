using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

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
        [SwaggerOperation(Summary = "Get all passengers", Description = "Get a list of all passengers.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(IEnumerable<Passenger>))]
        public ActionResult<IEnumerable<Passenger>> GetPassengers()
        {
            var passengers = _passengerRepository.GetPassengers();
            return Ok(passengers);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get passenger by ID", Description = "Get information about a specific passenger.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(Passenger))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Passenger not found")]
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
        [SwaggerOperation(Summary = "Create a new passenger", Description = "Add a new passenger to the system.")]
        [SwaggerResponse(StatusCodes.Status201Created, "Passenger created", typeof(Passenger))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid input")]
        public ActionResult<Passenger> CreatePassenger([FromBody] Passenger passenger)
        {
            _passengerRepository.CreatePassenger(passenger);
            return Ok(passenger);
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Update a passenger", Description = "Update information about a specific passenger.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Passenger updated", typeof(Passenger))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid input")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Passenger not found")]
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
        [SwaggerOperation(Summary = "Delete a passenger", Description = "Delete a specific passenger from the system.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Passenger deleted")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Passenger not found")]
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
