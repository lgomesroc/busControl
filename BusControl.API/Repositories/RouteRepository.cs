using BusControl.API.Interfaces.Repositories;
using BusControl.API.DataBase.SqlConnection;

namespace BusControl.API.Repositories
{
    public class RouteRepository : IRouteRepository
    {
        public RouteRepository() { }
        private readonly BusControlDBContext _DbContext;
        public RouteRepository(BusControlDBContext DbContext)
        {
            _DbContext = DbContext;
        }
        public IQueryable<Route> GetRoutes()
        {
            throw new NotImplementedException();
        }

        public Route GetRouteById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateRoute(Route route)
        {
            throw new NotImplementedException();
        }

        public void UpdateRoute(int id, Route route)
        {
            throw new NotImplementedException();
        }

        public void DeleteRoute(int id)
        {
            throw new NotImplementedException();
        }

        IQueryable<Route> IRouteRepository.GetRoutes()
        {
            throw new NotImplementedException();
        }

        Route IRouteRepository.GetRouteById(int id)
        {
            throw new NotImplementedException();
        }

        void IRouteRepository.CreateRoute(Route route)
        {
            throw new NotImplementedException();
        }

        void IRouteRepository.UpdateRoute(int id, Route route)
        {
            throw new NotImplementedException();
        }

        void IRouteRepository.DeleteRoute(int id)
        {
            throw new NotImplementedException();
        }
    }
}
