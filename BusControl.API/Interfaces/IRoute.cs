namespace BusControl.API.Interfaces
{
    public interface IRoute
    {
        int Id { get; set; }
        string Name { get; set; }
        string Origin { get; set; }
        string Destination { get; set; }
    }
}
