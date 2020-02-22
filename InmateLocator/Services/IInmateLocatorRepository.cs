using System;
using System.Collections.Generic;
using InmateLocator.Entities;

namespace InmateLocator.Services
{
    public interface IInmateLocatorRepository
    {
        IEnumerable<Location> GetLocations(Guid InmateId);
        Location GetLocation(Guid inmateId, Guid locationId);
        IEnumerable<Inmate> GetInmates();
        Inmate GetInmate(Guid inmateId);
        IEnumerable<Inmate> GetInmates(IEnumerable<Guid> inmateIds);
        bool InmateExists(Guid inmateId);
    }
}
