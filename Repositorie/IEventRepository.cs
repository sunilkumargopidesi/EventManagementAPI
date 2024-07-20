using EventManagementAPI.Models;

namespace EventManagementAPI.Repositorie
{
    public interface IEventRepository : IRepository<Event>
    {
        Task<IEnumerable<Event>> SearchEventsAsync(string name, DateTime? date, string location);
    }
}

