using System;
using Agendamento.Models.Enums;

namespace Agendamento.Models
{
    public class Schedule
    {
        public Schedule(){
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public Client Client {get; set;}

        public int IdClient {get; set;}

        public DateTime Date {get; set;}

        public EStatus Status {get; set;}

        public string Comments { get; set; }
    }
}