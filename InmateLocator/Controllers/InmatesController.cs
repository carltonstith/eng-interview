using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using InmateLocator.Models;
using InmateLocator.Services;
using AutoMapper;

namespace InmateLocator.Controllers
{
    [Route("api/inmates")]
    [ApiController]
    public class InmatesController : ControllerBase
    {
        private readonly IInmateLocatorRepository _inmateLocatorRepository;
        private readonly IMapper _mapper;

        public InmatesController(IInmateLocatorRepository inmateLocatorRepository, IMapper mapper)
        {
            _inmateLocatorRepository = inmateLocatorRepository ??
                throw new ArgumentNullException(nameof(inmateLocatorRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        public ActionResult<IEnumerable<InmateDto>> GetInmates()
        {
            //throw new Exception("Test Exception");
            var inmatesFromRepo = _inmateLocatorRepository.GetInmates();
            var inmates = new List<InmateDto>();

            return Ok(_mapper.Map<IEnumerable<InmateDto>>(inmatesFromRepo));
        }

        [HttpGet("{inmateId}")]
        public IActionResult GetInmate(Guid inmateId)
        {
            var inmateFromRepo = _inmateLocatorRepository.GetInmate(inmateId);

            if (inmateFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<InmateDto>(inmateFromRepo));
        }
    }
}
