using Microsoft.AspNetCore.Mvc;
using BusControl.API.Models;
using BusControl.API.Interfaces.Repositories;

namespace BusControl.API.Controllers
{
    [Route("drivers")]
    public class DriverController : Controller
    {
        private readonly IDriverRepository _driverRepository;

        public DriverController(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DriverModel>> GetDrivers()
        {
            var drivers = _driverRepository.GetDrivers();
            return Ok(drivers);
        }

        [HttpGet("{id}")]
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
        public ActionResult<DriverModel> CreateDriver([FromBody] DriverModel driver)
        {
            _driverRepository.CreateDriver(driver);
            return Ok(driver);
        }

        [HttpPut("{id}")]
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
