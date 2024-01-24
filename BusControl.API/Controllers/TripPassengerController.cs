using Microsoft.AspNetCore.Mvc;
using BusControl.API.Models;
using BusControl.API.Interfaces.Repositories;

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
        public ActionResult<IEnumerable<TripPassengerModel>> GetPassengersByTrip(int tripId)
        {
            var passengers = _tripPassengerRepository.GetByTripId(tripId);
            return Ok(passengers);
        }

        [HttpGet("/passengers/{passengerId}/trips")]
        public ActionResult<IEnumerable<TripPassengerModel>> GetTripsByPassenger(int passengerId)
        {
            var trips = _tripPassengerRepository.GetByPassengerId(passengerId);
            return Ok(trips);
        }

        [HttpPost("/trips/{tripId}/passengers")]
        public ActionResult<TripPassengerModel> AddPassengerToTrip(int tripId, [FromBody] TripPassengerModel tripPassenger)
        {
            // Implemente a lógica necessária para adicionar um passageiro a uma viagem
            _tripPassengerRepository.CreateTripPassenger(tripPassenger);
            return Ok(tripPassenger);
        }

        [HttpDelete("/trips/{tripId}/passengers/{passengerId}")]
        public ActionResult RemovePassengerFromTrip(int tripId, int passengerId)
        {
            // Implemente a lógica necessária para remover um passageiro de uma viagem
            _tripPassengerRepository.DeleteTripPassenger(tripId, passengerId);
            return Ok();
        }
    }
}
