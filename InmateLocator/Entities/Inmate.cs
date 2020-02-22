using System;
using System.ComponentModel.DataAnnotations;

namespace InmateLocator.Entities
{
    public class Inmate
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(6)]
        public string PID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTimeOffset DateOfBirth { get; set; }
    }
}
