using System;
using InmateLocator.DbContexts;
using InmateLocator.Entities;
using System.Collections.Generic;
using System.Linq;

namespace InmateLocator.Services
{
    public class InmateLocatorRepository : IInmateLocatorRepository, IDisposable
    {
        private readonly InmateLocatorContext _context;

        public InmateLocatorRepository(InmateLocatorContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Location GetLocation(Guid inmateId, Guid locationId)
        {
            if (locationId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(inmateId));
            }

            if (locationId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(locationId));
            }

            return _context.Locations
                .Where(c => c.InmateId == inmateId && c.Id ==
                    locationId).FirstOrDefault();
        }

        public IEnumerable<Location> GetLocations(Guid inmateId)
        {
            if (inmateId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(inmateId));
            }

            return _context.Locations
                .Where(c => c.InmateId == inmateId)
                .OrderBy(c => c.CurrentLocation).ToList();
        }

        public Inmate GetInmate(Guid inmateId)
        {
            if (inmateId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(inmateId));
            }

            return _context.Inmates.FirstOrDefault(a => a.Id == inmateId);
        }

        public IEnumerable<Inmate> GetInmates()
        {
            return _context.Inmates.ToList<Inmate>();
        }

        public IEnumerable<Inmate> GetInmates(IEnumerable<Guid>
            inmateIds)
        {
            if (inmateIds == null)
            {
                throw new ArgumentNullException(nameof(inmateIds));
            }

            return _context.Inmates.Where(a =>
                inmateIds.Contains(a.Id))
                    .OrderBy(a => a.FirstName)
                    .OrderBy(a => a.LastName)
                    .ToList();
        }

        public bool InmateExists(Guid inmateId)
        {
            if (inmateId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(inmateId));
            }

            return _context.Inmates.Any(a => a.Id == inmateId);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }
    }
}
