using BusControl.API.Interfaces;

namespace BusControl.API.Models
{
    public class PassengerModel : IPassenger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        
        public PassengerModel(int id, string name, string cpf, string email, string phone) 
        {
            this.Id = id;
            this.Name = name;
            this.CPF = cpf;
            this.Email = email;
            this.Phone = phone;
        }
    }
}
