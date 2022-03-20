using API.LocaCar.Data;
using API.LocaCar.DTOs.EnderecoDtos;
using API.LocaCar.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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

        [HttpGet]
        public IActionResult ListEnd()
        {
            List<Endereco> enderecos = _context.Enderecos.ToList();

            if (enderecos != null)
            {
                List<ReadEnderecoDto> EndDto = _mapper.Map<List<ReadEnderecoDto>>(enderecos);

                return Ok(EndDto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{Id}")]
        public IActionResult FindEnd(int Id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(end => end.Id == Id);

            if (endereco != null)
            {
                ReadEnderecoDto endDto = _mapper.Map<ReadEnderecoDto>(endereco);
                return Ok(endDto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{Id}")]
        public IActionResult UpdateEnd(int Id, [FromBody] UpdateEnderecoDto updtEnd)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(en => en.Id == Id);

            if (endereco != null)
            {
                _mapper.Map(updtEnd, endereco);
                _context.Update(endereco);
                _context.SaveChanges();
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteEnd(int Id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(end => end.Id == Id);

            if (endereco != null)
            {
                _context.Remove(endereco);
                _context.SaveChanges();

                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
