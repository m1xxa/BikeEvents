using System;
using System.Collections.Generic;
using System.Linq;
using BikeEvents.DataAccess.Contexts;
using BikeEvents.DataAccess.Interfaces;
using BikeEvents.DomainModels;

namespace BikeEvents.DataAccess
{
    
    public class EventRepository : IEventRepository
    {
        private readonly EventsContext _eventsContext;

        public EventRepository(EventsContext eventsContext)
        {
            _eventsContext = eventsContext;
        }

        public List<Event> GetAll()
        {
            return _eventsContext.Events.ToList();
        }

        public List<Event> GetEventsByLocation(string location)
        {
            return _eventsContext.Events.Where(x => x.Locations == location).ToList();
        }

        public List<Event> GetEventsByPeriod(DateTime dateFrom, DateTime dateTo)
        {
            return _eventsContext.Events.Where(x => x.StartTime >= dateFrom && x.StartTime <= dateTo).ToList();
        }

        public void AddNewEvent(Event item)
        {
            _eventsContext.Events.Add(item);
            _eventsContext.SaveChanges();
        }

        public Event GetEventById(int id)
        {
            return _eventsContext.Events.FirstOrDefault(x => x.Id == id);
        }
    }
}