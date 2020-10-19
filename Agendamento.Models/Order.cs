using System;
using System.Collections.Generic;

namespace Agendamento.Models {
    public class Order {
        public Order (Guid id) {

            this.Id = Guid.NewGuid();

        }
        public Guid Id { get; set; }

        public Client Client {get; set;}

        public int IdClient {get; set;}

        public IList<Service> Services { get; set; }

        public decimal Value {get; set; }

        public string Comments {get; set;}

        
    }
}