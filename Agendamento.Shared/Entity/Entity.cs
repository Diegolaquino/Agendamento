using Flunt.Notifications;
using System;

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