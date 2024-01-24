namespace BusControl.API.Interfaces
{
    public interface ITrip
    {
        int Id { get; set; }
        int BusId { get; set; }
        DateTime DepartureTieme { get; set; }  
        DateTime ArrivalTime { get; set; }
        int Duration { get; set; }
        int LimitPassengers { get; set; }
        string Passengers { get; set; }
        int DriverId { get; set; }
    }
}
