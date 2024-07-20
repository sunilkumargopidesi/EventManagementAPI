using AutoMapper;
using EventManagementAPI.DTOs_folder;
using EventManagementAPI.Models;
using EventManagementAPI.Repositorie;
using EventManagementAPI.Services_folder;

namespace EventManagementAPI.implementServices
{            
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EventDto>> GetAllEventsAsync()
        {
            var events = await _eventRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<EventDto>>(events);
        }

        public async Task<EventDto> GetEventByIdAsync(int id)
        {
            var @event = await _eventRepository.GetByIdAsync(id);
            if (@event == null)
            {
                throw new ApplicationException("Event not found");
            }
            return _mapper.Map<EventDto>(@event);
        }

        public async Task<EventDto> CreateEventAsync(CreateEventDto createEventDto)
        {
            var @event = _mapper.Map<Event>(createEventDto);
            await _eventRepository.AddAsync(@event);
            return _mapper.Map<EventDto>(@event);
        }

        public async Task<EventDto> UpdateEventAsync(int id, UpdateEventDto updateEventDto)
        {
            var @event = await _eventRepository.GetByIdAsync(id);
            if (@event == null)
            {
                throw new ApplicationException("Event not found");
            }

            _mapper.Map(updateEventDto, @event);
            await _eventRepository.UpdateAsync(@event);
            return _mapper.Map<EventDto>(@event);
        }

        public async Task DeleteEventAsync(int id)
        {
            var @event = await _eventRepository.GetByIdAsync(id);
            if (@event == null)
            {
                throw new ApplicationException("Event not found");
            }

            await _eventRepository.DeleteAsync(@event);
        }

        public async Task<IEnumerable<EventDto>> SearchEventsAsync(EventSearchDto searchDto)
        {
            var events = await _eventRepository.SearchEventsAsync(searchDto.Name, searchDto.Date, searchDto.Location);
            return _mapper.Map<IEnumerable<EventDto>>(events);
        }

    }
}
