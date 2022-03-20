using API.LocaCar.Data;
using API.LocaCar.DTOs.CarroDtos;
using API.LocaCar.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API.LocaCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : Controller
    {
        private LocaCarDbContext _context;
        private IMapper _mapper;

        public CarroController(LocaCarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddCar(CreateCarroDto nCar)
        {
            Carro newCar = _mapper.Map<Carro>(nCar);
            _context.Carros.Add(newCar);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult ListCar()
        {
            List<Carro> carros = _context.Carros.ToList();

            if (carros != null)
            {
                List<ReadCarroDto> carroDto = _mapper.Map<List<ReadCarroDto>>(carros);
                return Ok(carroDto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{Id}")]
        public IActionResult FindCar(int Id)
        {
            Carro carros = _context.Carros.FirstOrDefault(c => c.Id == Id);

            if (carros != null)
            {
                ReadCarroDto carroDto = _mapper.Map<ReadCarroDto>(carros);
                return Ok(carroDto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCar(int id, [FromBody] UpdateCarroDto updtCar)
        {
            Carro carro = _context.Carros.FirstOrDefault(c => c.Id == id);

            if (carro != null)
            {
                _mapper.Map(updtCar, carro);
                _context.Carros.Update(carro);
                _context.SaveChanges();

                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{Id}")]
        public IActionResult RemoveCar(int Id)
        {
            Carro carro = _context.Carros.FirstOrDefault(c => c.Id == Id);

            if (carro != null)
            {
                _context.Carros.Remove(carro);
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
