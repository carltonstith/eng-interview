using System;

namespace InmateLocator.Models
{
    public class LocationDto
    {
        public Guid Id { get; set; }

        public string CurrentLocation { get; set; }

        public Guid InmateId { get; set; }
    }
}
