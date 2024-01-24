using BusControl.API.Interfaces;
using BusControl.API.DataBase.SqlConnection;

namespace BusControl.API.Models
{
    public class BusModel : IBus
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Plate { get; set; }
        public string Line { get; set; }
        public string Route { get; set; }
        int IBus.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBus.Number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBus.Plate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBus.Line { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBus.Route { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public BusModel(int id, string number, string plate, string line, string route)
        {
            int Id = id;
            string Number = number;
            string Plate = plate;
            string Line = line;
            string Route = route;
        }
    }
}
