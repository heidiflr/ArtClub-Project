using DeepPurple.ApplicationLogic.Abstractions;
using DeepPurple.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepPurple.ApplicationLogic.Services
{
    public class EventServices
    {
        private IEventRepository eventRepository;

        public EventServices(IEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        public IEnumerable<Event> GetAll()
        {
            return eventRepository.GetAll();
        }

        public void AddEvent(string EventName, string EventDescription)
        {
            eventRepository.Add(new Data.Event
            {
                EventID = Guid.NewGuid(),
                EventName = EventName,
                EventDescription = EventDescription
            });

        }
    }
}
