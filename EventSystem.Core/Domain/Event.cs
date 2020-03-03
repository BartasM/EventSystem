using System;
using System.Collections.Generic;
using System.Text;

namespace EventSystem.Core.Domain
{
    public class Event : Entity
    {

        private ISet<Ticket> _tickets = new HashSet<Ticket>();

        public string Name { get; protected set; }
        public string Description { get; protected set; } //opis Eventu
        public DateTime CreatedAt { get; protected set; } //utworzenie Eventu data
        public DateTime StartDate { get; protected set; } //rozpoczęcie Eventu
        public DateTime EndDate { get; protected set; } //zakończenie Eventu
        public DateTime UpdatedAt { get; protected set; } //edycja Eventu

        public IEnumerable<Ticket> Tickets => _tickets;

        protected Event()
        {
        }

        public Event(Guid id, string name, string description, DateTime startDate, DateTime endDate)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public void AddTickets (int amout, decimal price)
        {
            var seating = _tickets.Count + 1;
            for(var i=0; i<amout; i++)
            {
                _tickets.Add(new Ticket(this, seating, price));
                seating++;
            }
        }
    }
}
