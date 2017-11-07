using System.Collections.Generic;
using MediatR;

namespace Filmoteka.Domain.SeedWork
{
    public abstract class Entity
    {
        protected virtual int Id { get; set; }

        private List<INotification> DomainEvents { get; set; }

        public void AddDomainEvent(INotification eventItem)
        {
            DomainEvents = DomainEvents ?? new List<INotification>();
            DomainEvents.Add(eventItem);
        }

        public void RemoveDomainEvent(INotification eventItem)
        {
            if (DomainEvents is null) return;
            DomainEvents.Remove(eventItem);
        }

    }
}