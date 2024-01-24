using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Interfaces.Repositories;
using BusControl.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusControl.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TripController : ControllerBase
    {
        private readonly ITripRepository _tripRepository;
        private TripModel tripModel;

        public TripController(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Trip>> GetTrips()
        {
            var trips = _tripRepository.GetTrips();
            return Ok(trips);
        }

        [HttpGet("{id}")]
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
        public ActionResult<Trip> CreateTrip(Trip trip)
        {
            _tripRepository.CreateRoute(tripModel);
            return Ok(trip);
        }

        [HttpPut("{id}")]
        public ActionResult<Trip> UpdateTrip(int id, Trip trip)
        {
            var existingTrip = _tripRepository.GetTripById(id);
            if (existingTrip == null)
            {
                return NotFound();
            }

            _tripRepository.UpdateTrip(id, tripModel);
            return Ok(trip);
        }

        [HttpDelete("{id}")]
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
