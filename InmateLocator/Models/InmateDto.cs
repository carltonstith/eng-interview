using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InmateLocator.Models
{
    public class InmateDto
    {
        public Guid Id { get; set; }

        public string PID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //public int Age { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }

        public  Guid LocationId { get; set; }

        public string CurrentLocation { get; set; }
    }
}
