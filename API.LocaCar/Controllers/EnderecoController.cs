using API.LocaCar.Data;
using API.LocaCar.DTOs.EnderecoDtos;
using API.LocaCar.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.LocaCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : Controller
    {
        private LocaCarDbContext _context;
        private IMapper _mapper;

        public EnderecoController(LocaCarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddEnd(CreateEnderecoDto nEnd)
        {
            Endereco endereco = _mapper.Map<Endereco>(nEnd);
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
            return Ok();
        }
    }
}
