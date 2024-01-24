using BusControl.API.Interfaces;

namespace BusControl.API.Models
{
    public class RouteModel : IRoute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

        public RouteModel(int id, string name, string origin, string destination)
        {
            int Id = id;
            string Name = name;
            string Origin = origin;
            string Destination = destination;
        }
    }
}
