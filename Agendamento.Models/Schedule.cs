using System;
using Agendamento.Models.Enums;

namespace Agendamento.Models
{
    public class Schedule
    {
        public Schedule(Client client){
            this.Id = Guid.NewGuid();
            this.Client = client;
        }

        public Schedule(){

        }

        public Guid Id { get; set; }

        public Client Client {get; set;}

        public int IdClient {get; set;}

        public DateTime ScheduleDate {get; set;}

        public EStatus Status {get; set;}

        public string Comments { get; set; }
    }
}