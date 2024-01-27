using BusControl.API.Interfaces.Repositories;
using BusControl.API.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace BusControl.API.Controllers
{
    public class TripPassengerController : Controller
    {
        private readonly ITripPassengerRepository _tripPassengerRepository;

        public TripPassengerController(ITripPassengerRepository tripPassengerRepository)
        {
            _tripPassengerRepository = tripPassengerRepository;
        }

        [HttpGet("/trips/{tripId}/passengers")]
        [SwaggerOperation(Summary = "Get passengers by trip ID", Description = "Get a list of passengers for a specific trip.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(IEnumerable<TripPassengerModel>))]
        public ActionResult<IEnumerable<TripPassengerModel>> GetPassengersByTrip(int tripId)
        {
            var passengers = _tripPassengerRepository.GetByTripId(tripId);
            return Ok(passengers);
        }

        [HttpGet("/passengers/{passengerId}/trips")]
        [SwaggerOperation(Summary = "Get trips by passenger ID", Description = "Get a list of trips for a specific passenger.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(IEnumerable<TripPassengerModel>))]
        public ActionResult<IEnumerable<TripPassengerModel>> GetTripsByPassenger(int passengerId)
        {
            var trips = _tripPassengerRepository.GetByPassengerId(passengerId);
            return Ok(trips);
        }

        [HttpPost("/trips/{tripId}/passengers")]
        [SwaggerOperation(Summary = "Add passenger to trip", Description = "Add a passenger to a specific trip.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Passenger added to trip", typeof(TripPassengerModel))]
        public ActionResult<TripPassengerModel> AddPassengerToTrip(int tripId, [FromBody] TripPassengerModel tripPassenger)
        {
            _tripPassengerRepository.CreateTripPassenger(tripPassenger);
            return Ok(tripPassenger);
        }

        [HttpDelete("/trips/{tripId}/passengers/{passengerId}")]
        [SwaggerOperation(Summary = "Remove passenger from trip", Description = "Remove a passenger from a specific trip.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Passenger removed from trip")]
        public ActionResult RemovePassengerFromTrip(int tripId, int passengerId)
        {
            _tripPassengerRepository.DeleteTripPassenger(tripId, passengerId);
            return Ok();
        }
    }
}
