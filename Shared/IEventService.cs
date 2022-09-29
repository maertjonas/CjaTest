using Domain;

namespace Shared
{
    public interface IEventService
    {
        Task<IEnumerable<Event>> ReadEventsAsync();
        Task<Event> ReadEventAsync(long id);
        Task<Event> CreateEventsAsync(Event eventToCreate);
        Task<Event> UpdateEventAsync(Event eventToUpdate);
    }
}