using API.LocaCar.Data;
using API.LocaCar.DTOs.AgenciaDtos;
using API.LocaCar.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

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
    }
}
