using System;
using System.Collections.Generic;
using AutoMapper;
using InmateLocator.Models;
using InmateLocator.Services;
using Microsoft.AspNetCore.Mvc;

namespace InmateLocator.Controllers
{
    [Route("api/locations/{inmateId}/locations")]
    public class LocationsController : ControllerBase
    {
        private readonly IInmateLocatorRepository _inmateLocatorRepository;
        private readonly IMapper _mapper;

        public LocationsController(IInmateLocatorRepository inmateLocatorRepository, IMapper mapper)
        {
            _inmateLocatorRepository = inmateLocatorRepository ??
                throw new ArgumentNullException(nameof(inmateLocatorRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<LocationDto>>
            GetLocationsForInmate(Guid inmateId)
        {
            if (!_inmateLocatorRepository.InmateExists(inmateId))
            {
                return NotFound();
            }

            var locationsForInmateFromRepo = _inmateLocatorRepository.GetLocations(inmateId);
            return Ok(_mapper.Map<IEnumerable<LocationDto>>(locationsForInmateFromRepo));
        }

        [HttpGet("{locationId}")]
        public ActionResult<IEnumerable<LocationDto>> GetLocationForInmate(Guid inmateId, Guid locationId)
        {
            if (!_inmateLocatorRepository.InmateExists(inmateId))
            {
                return NotFound();
            }

            var locationForInmateFromRepo = _inmateLocatorRepository.GetLocation(inmateId, locationId);

            if (locationForInmateFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<LocationDto>(locationForInmateFromRepo));
        }
    }
}
