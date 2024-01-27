using BusControl.API.Interfaces.Repositories;
using BusControl.API.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace BusControl.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverRepository _driverRepository;

        public DriverController(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all drivers", Description = "Get a list of all drivers.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(IEnumerable<DriverModel>))]
        public ActionResult<IEnumerable<DriverModel>> GetDrivers()
        {
            var drivers = _driverRepository.GetDrivers();
            return Ok(drivers);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get driver by ID", Description = "Get information about a specific driver.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(DriverModel))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Driver not found")]
        public ActionResult<DriverModel> GetDriverById(int id)
        {
            var driver = _driverRepository.GetDriverById(id);
            if (driver == null)
            {
                return NotFound();
            }
            return Ok(driver);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create a new driver", Description = "Add a new driver to the system.")]
        [SwaggerResponse(StatusCodes.Status201Created, "Driver created", typeof(DriverModel))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid input")]
        public ActionResult<DriverModel> CreateDriver([FromBody] DriverModel driver)
        {
            _driverRepository.CreateDriver(driver);
            return Ok(driver);
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Update a driver", Description = "Update information about a specific driver.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Driver updated", typeof(DriverModel))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid input")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Driver not found")]
        public ActionResult<DriverModel> UpdateDriver(int id, [FromBody] DriverModel driver)
        {
            var existingDriver = _driverRepository.GetDriverById(id);
            if (existingDriver == null)
            {
                return NotFound();
            }

            _driverRepository.UpdateDriver(id, driver);
            return Ok(driver);
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Delete a driver", Description = "Delete a specific driver from the system.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Driver deleted")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Driver not found")]
        public ActionResult DeleteDriver(int id)
        {
            var existingDriver = _driverRepository.GetDriverById(id);
            if (existingDriver == null)
            {
                return NotFound();
            }

            _driverRepository.DeleteDriver(id);
            return Ok();
        }
    }
}
