using EventSystem.Core.Domain;
using EventSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSystem.infrastructure.Repositories
{
    public class EventRepository : IEventRepository
    {
        private static readonly ISet<Event> _events = new HashSet<Event>();

        public async Task<Event> GetAsync(Guid id)
        => await Task.FromResult(_events.SingleOrDefault(x => x.Id == id));

        public async Task AddAsync(Event @event)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Event>> BrowseAsync(string name = "")
        {
            throw new NotImplementedException();
        }





        public async Task<Event> GetAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Event @event)
        {
            throw new NotImplementedException();
        }
        public async Task DeleteAsync(Event @event)
        {
            throw new NotImplementedException();
        }
    }
}
