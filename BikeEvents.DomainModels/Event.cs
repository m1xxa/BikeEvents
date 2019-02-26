using System;

namespace BikeEvents.DomainModels
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public string Picture { get; set; }
        public string Locations { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
    }
}