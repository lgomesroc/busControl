namespace BusControl.API.Interfaces
{
    public interface IDriver
    {
        int Id { get; set; }
        string login { get; set; }
        string Name { get; set; }
        string CPF { get; set; }
        string Email { get; set; }
    }
}
