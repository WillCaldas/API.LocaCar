using API.LocaCar.Data;
using API.LocaCar.DTOs.CarroDtos;
using API.LocaCar.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

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
    }
}
