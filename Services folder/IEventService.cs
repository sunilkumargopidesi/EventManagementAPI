using EventManagementAPI.DTOs_folder;

namespace EventManagementAPI.Services_folder
{
    public interface IEventService
    {
        Task<IEnumerable<EventDto>> GetAllEventsAsync();
        Task<EventDto> GetEventByIdAsync(int id);
        Task<EventDto> CreateEventAsync(CreateEventDto createEventDto);
        Task<EventDto> UpdateEventAsync(int id, UpdateEventDto updateEventDto);
        Task DeleteEventAsync(int id);
        Task<IEnumerable<EventDto>> SearchEventsAsync(EventSearchDto searchDto);
    }
}
