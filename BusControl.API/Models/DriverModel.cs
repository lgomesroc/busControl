using BusControl.API.Interfaces;

namespace BusControl.API.Models
{
    public class DriverModel : IDriver
    {
        public DriverModel() {}
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        int IDriver.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IDriver.login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IDriver.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IDriver.CPF { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IDriver.Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DriverModel(int id, string login, string name, string cpf, string email)
        {
            Id = id;
            Login = login;
            Name = name;
            Cpf = cpf;
            Email = email;
        }
    }
}
