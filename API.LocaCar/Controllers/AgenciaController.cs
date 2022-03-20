using API.LocaCar.Data;
using API.LocaCar.DTOs.AgenciaDtos;
using API.LocaCar.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API.LocaCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgenciaController : Controller
    {
        private LocaCarDbContext _context;
        private IMapper _mapper;

        public AgenciaController(LocaCarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddAgency(CreateAgenciaDto nAgency)
        {
            Agencia agencia = _mapper.Map<Agencia>(nAgency);
            _context.Agencias.Add(agencia);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult ListAgency()
        {
            List<Agencia> agencias = _context.Agencias.ToList();

            if (agencias != null)
            {
                List<ReadAgenciaDto> agenciaDto = _mapper.Map<List<ReadAgenciaDto>>(agencias);
                return Ok(agenciaDto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{Id}")]
        public IActionResult FindAgency(int Id)
        {
            Agencia agencia = _context.Agencias.FirstOrDefault(a => a.Id == Id);
            if (agencia != null)
            {
                var agenciaDto = _mapper.Map<ReadAgenciaDto>(agencia);
                return Ok(agenciaDto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{Id}")]
        public IActionResult UpdateAgency(int Id, [FromBody] UpdateAgenciaDto newAgency)
        {
            Agencia agencia = _context.Agencias.FirstOrDefault(a => a.Id == Id);

            if (agencia != null)
            {
                _mapper.Map(newAgency, agencia);
                _context.Update(agencia);
                _context.SaveChanges();

                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteAgency(int Id)
        {
            Agencia agencia = _context.Agencias.FirstOrDefault(a => a.Id == Id);

            if (agencia != null)
            {
                _context.Agencias.Remove(agencia);
                _context.SaveChanges();

                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
