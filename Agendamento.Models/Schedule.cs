using System;
using Agendamento.Models.Enums;
using Agendamento.Shared.Entity;
using Flunt.Notifications;
using Flunt.Validations;

namespace Agendamento.Models
{
    public class Schedule : Entity, IValidatable
    {
        public Schedule(Client client){
            this.Client = client;
        }

        public Schedule()
        {

        }

        public void Validate(){
           
            AddNotifications( new Contract()
                .IsNotNull(Client, "Schedule.Client", "O client não pode ser nulo")

            );
        
        }

        public Client Client {get; set;}

        public int IdClient {get; set;}

        public DateTime ScheduleDate {get; set;}

        public EStatus Status {get; set;}

        public string Comments { get; set; }
    }
}