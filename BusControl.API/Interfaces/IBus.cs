namespace BusControl.API.Interfaces
{
    public interface IBus
    {
        int Id { get; set; }
        string Number { get; set; }
        string Plate { get; set; }  
        string Line { get; set; }
        string Route { get; set; }
    }
}
