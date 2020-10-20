using System;
using Agendamento.Models.Enums;
using Agendamento.Shared.Entity;
using Flunt.Validations;

namespace Agendamento.Models
{
    public class Schedule : Entity
    {
        public Schedule(Client client){
            this.Client = client;
            if(Client == null)
            {
                AddNotifications( new Contract()
                    .Requires()
                    .IsTrue(Client == null, "Schedule.Client", "O client não pode ser nulo")

                );
            }
        }

        public Schedule(){

        }

        public Client Client {get; set;}

        public int IdClient {get; set;}

        public DateTime ScheduleDate {get; set;}

        public EStatus Status {get; set;}

        public string Comments { get; set; }
    }
}