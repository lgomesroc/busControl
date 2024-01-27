using BusControl.API.DataBase.SqlConnection;
using BusControl.API.Interfaces.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace BusControl.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusRepository _busRepository;

        public BusController(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }

        [HttpGet("/buses")]
        [SwaggerOperation(Summary = "Get all buses", Description = "Get a list of all buses.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(IEnumerable<Bus>))]
        public ActionResult<IEnumerable<Bus>> GetBuses()
        {
            var buses = _busRepository.GetBuses();
            return Ok(buses);
        }

        [HttpGet("/buses/{id:int}")]
        [SwaggerOperation(Summary = "Get bus by ID", Description = "Get information about a specific bus.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(Bus))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Bus not found")]
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
        [SwaggerOperation(Summary = "Add a new bus", Description = "Add a new bus to the system.")]
        [SwaggerResponse(StatusCodes.Status201Created, "Bus created", typeof(Bus))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid input")]
        public ActionResult<Bus> AddBus([FromBody] Bus bus)
        {
            _busRepository.AddBus(bus);
            _busRepository.SaveChanges();

            return CreatedAtAction(nameof(GetBusById), new { id = bus.Id }, bus);
        }

        [HttpPut("/buses/{id:int}")]
        [SwaggerOperation(Summary = "Update a bus", Description = "Update information about a specific bus.")]
        [SwaggerResponse(StatusCodes.Status204NoContent, "Bus updated")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid input")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Bus not found")]
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
        [SwaggerOperation(Summary = "Delete a bus", Description = "Delete a specific bus from the system.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Bus deleted")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Bus not found")]
        public ActionResult DeleteBus(int id)
        {
            var existingBus = _busRepository.GetBusById(id);

            if (existingBus == null)
            {
                return NotFound();
            }

            _busRepository.DeleteBus(id);
            _busRepository.SaveChanges();

            return Ok();
        }
    }
}

