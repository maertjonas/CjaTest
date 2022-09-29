using Domain;
using Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class EventService : IEventService
    {
        private readonly ApplicationContext _applicationContext;

        public EventService(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }


        public async Task<Event> CreateEventsAsync(Event eventToCreate)
        {
            throw new NotImplementedException();

        }
        public async Task<Event> ReadEventAsync(long id)
        {
            throw new NotImplementedException();

        }

        public async Task<IEnumerable<Event>> ReadEventsAsync()
        {
            await Task.Delay(100);
            return _applicationContext.Events.AsNoTracking().ToList();
        }

        public async Task<Event> UpdateEventAsync(Event eventToUpdate)
        {
            throw new NotImplementedException();
        }

       
    }
}
