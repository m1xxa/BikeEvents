using System;
using System.Collections.Generic;
using BikeEvents.DomainModels;

namespace BikeEvents.DataAccess.Interfaces
{
    public interface IEventRepository
    {
        Event GetEventById(int id);
        List<Event> GetAll();
        List<Event> GetEventsByLocation(string location);
        List<Event> GetEventsByPeriod(DateTime dateFrom, DateTime dateTo);
        
        void AddNewEvent(Event item);
    }
}