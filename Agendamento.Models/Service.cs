using Agendamento.Shared.Entity;
using Flunt.Validations;

namespace Agendamento.Models
{
    public class Service : Entity, IValidatable
    {
        public Service()
        {

        }

        public Service(string name, decimal value, string description = "")
        {
            Name = name;
            Value = value;
            Description = description;
        }

        public string Name {get; set; }

        public decimal Value {get; set; }

        public string Description {get; set;}

        public void Validate()
        {
            AddNotifications(new Contract()
                .IsNotNullOrEmpty(Name, "Service.Name", "O nome deve ser preenchido")
                .IsLowerOrEqualsThan(Value, 0, "Service.Value", "O valor do serviço não pode ser 0 ou menor que 0")
            );
        }
    }
}