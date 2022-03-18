using API.LocaCar.Data;
using API.LocaCar.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.LocaCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : Controller
    {
        private LocaCarDbContext _context;

        public CarroController(LocaCarDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddCar(Carro nCar)
        {
            _context.Carros.Add(nCar);
            _context.SaveChanges();
            return Ok(nCar);
        }
    }
}
