namespace BusControl.API.Interfaces
{
    public interface IPassenger
    {
        int Id { get; set; }
        string Name { get; set; }
        string CPF { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
    }
}
