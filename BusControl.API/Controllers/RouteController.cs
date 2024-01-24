using Microsoft.AspNetCore.Mvc;
using BusControl.API.Models;
using BusControl.API.Interfaces.Repositories;

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
        public ActionResult<IEnumerable<Route>> GetRoutes()
        {
            var routes = _routeRepository.GetRoutes();
            return Ok(routes);
        }


        [HttpGet("/routes/{id}")]
        public ActionResult<Route> GetRouteById(int id)
        {
            return _routeRepository.GetRouteById(id);
        }

        [HttpPost("/routes")]
        public ActionResult<Route> CreateRoute(Route route)
        {
            _routeRepository.CreateRoute(route);
            return Ok(route);
        }

        [HttpPut("/routes/{id}")]
        public ActionResult<Route> UpdateRoute(int id, Route route)
        {
            _routeRepository.UpdateRoute(id, route);
            return Ok(route);
        }

        [HttpDelete("/routes/{id}")]
        public ActionResult DeleteRoute(int id)
        {
            _routeRepository.DeleteRoute(id);
            return Ok();
        }
    }
}
