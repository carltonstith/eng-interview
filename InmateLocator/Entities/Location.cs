using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InmateLocator.Entities
{
    public class Location
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string CurrentLocation { get; set; }

        [ForeignKey("InmateId")]
        public Inmate Inmate { get; set; }

        public Guid InmateId { get; set; }
    }
}
