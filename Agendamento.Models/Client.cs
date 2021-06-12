using Agendamento.Models.Enums;
using Agendamento.Shared.Entity;
using Flunt.Validations;

namespace Agendamento.Models
{
    public class Client : Entity, IValidatable
    {
        public Client()
        {

        }
        public Client(string name, string phone, EGender? gender = null, string email = "")
        {
            Name = name;
            Email = email;
            Phone = phone;
            Gender = gender;
        }

        public string Name {get; set;}  

        public string Email {get; set;}  

        public string Phone {get; set; }

        public EGender? Gender {get; set;}

        public void Validate()
        {
            AddNotifications(new Contract()
                .IsNotNullOrEmpty(Name, "Client.Name", "O nome deve ser preenchido")
                .IsNotNullOrEmpty(Phone, "Client.Phone", "O telefone deve ser preenchido")
            );
        }
    }
}