using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace BusControl.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TripController : ControllerBase
    {
        private readonly ITripRepository _tripRepository;

        public TripController(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all trips", Description = "Get a list of all trips.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(IEnumerable<Trip>))]
        public ActionResult<IEnumerable<Trip>> GetTrips()
        {
            var trips = _tripRepository.GetTrips();
            return Ok(trips);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get trip by ID", Description = "Get information about a specific trip.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(Trip))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Trip not found")]
        public ActionResult<Trip> GetTripById(int id)
        {
            var trip = _tripRepository.GetTripById(id);
            if (trip == null)
            {
                return NotFound();
            }

            return Ok(trip);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create a new trip", Description = "Add a new trip to the system.")]
        [SwaggerResponse(StatusCodes.Status201Created, "Trip created", typeof(Trip))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid input")]
        public ActionResult<Trip> CreateTrip([FromBody] Trip trip)
        {
            _tripRepository.CreateTrip(trip);
            return Ok(trip);
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Update a trip", Description = "Update information about a specific trip.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Trip updated", typeof(Trip))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid input")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Trip not found")]
        public ActionResult<Trip> UpdateTrip(int id, [FromBody] Trip trip)
        {
            var existingTrip = _tripRepository.GetTripById(id);
            if (existingTrip == null)
            {
                return NotFound();
            }

            _tripRepository.UpdateTrip(id, trip);
            return Ok(trip);
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Delete a trip", Description = "Delete a specific trip from the system.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Trip deleted")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Trip not found")]
        public ActionResult DeleteTrip(int id)
        {
            var existingTrip = _tripRepository.GetTripById(id);
            if (existingTrip == null)
            {
                return NotFound();
            }

            _tripRepository.DeleteTrip(id);
            return Ok();
        }
    }
}
