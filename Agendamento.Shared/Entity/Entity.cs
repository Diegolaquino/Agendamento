using System;
using Flunt.Notifications;

namespace Agendamento.Shared.Entity
{
    public abstract class Entity : Notifiable
    {
        public Entity(){
            this.Id = Guid.NewGuid();
        }

        public Guid Id {get; set;}
    }
}