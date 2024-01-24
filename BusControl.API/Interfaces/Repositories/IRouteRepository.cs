namespace BusControl.API.Interfaces.Repositories
{
    public interface IRouteRepository
    {
        IQueryable<Route> GetRoutes();
        Route GetRouteById(int id);
        void CreateRoute(Route route);
        void UpdateRoute(int id, Route route);
        void DeleteRoute(int id);
    }
}
