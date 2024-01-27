using BusControl.API.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace BusControl.API.Controllers
{
    public class RouteController : Controller
    {
        private readonly IRouteRepository _routeRepository;

        public RouteController(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }

        [HttpGet("/routes")]
        [SwaggerOperation(Summary = "Get all routes", Description = "Get a list of all routes.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(IEnumerable<Route>))]
        public ActionResult<IEnumerable<Route>> GetRoutes()
        {
            var routes = _routeRepository.GetRoutes();
            return Ok(routes);
        }

        [HttpGet("/routes/{id}")]
        [SwaggerOperation(Summary = "Get route by ID", Description = "Get information about a specific route.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Successful operation", typeof(Route))]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Route not found")]
        public ActionResult<Route> GetRouteById(int id)
        {
            return _routeRepository.GetRouteById(id);
        }

        [HttpPost("/routes")]
        [SwaggerOperation(Summary = "Create a new route", Description = "Add a new route to the system.")]
        [SwaggerResponse(StatusCodes.Status201Created, "Route created", typeof(Route))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid input")]
        public ActionResult<Route> CreateRoute([FromBody] Route route)
        {
            _routeRepository.CreateRoute(route);
            return Ok(route);
        }

        [HttpPut("/routes/{id}")]
        [SwaggerOperation(Summary = "Update a route", Description = "Update information about a specific route.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Route updated", typeof(Route))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid input")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Route not found")]
        public ActionResult<Route> UpdateRoute(int id, [FromBody] Route route)
        {
            _routeRepository.UpdateRoute(id, route);
            return Ok(route);
        }

        [HttpDelete("/routes/{id}")]
        [SwaggerOperation(Summary = "Delete a route", Description = "Delete a specific route from the system.")]
        [SwaggerResponse(StatusCodes.Status200OK, "Route deleted")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "Route not found")]
        public ActionResult DeleteRoute(int id)
        {
            _routeRepository.DeleteRoute(id);
            return Ok();
        }
    }
}
