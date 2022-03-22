using API.LocaCar.Data;
using API.LocaCar.Entities;
using System.Collections.Generic;
using System.Linq;

namespace API.LocaCar.Services
{
    public class ServiceCheck
    {
        private LocaCarDbContext _context;

        public ServiceCheck(LocaCarDbContext context)
        {
            _context = context;
        }
        
        public bool CheckCapacidade(int Id)
        {            
            int Count = 0;

            List<Carro> listCarro = _context.Carros.ToList();

            foreach (var item in listCarro)
            {
                if(item.AgenciaId == Id)
                {
                    Count++;
                }
            }

            Agencia agencia = _context.Agencias.FirstOrDefault(ag => ag.Id == Id);

            if (agencia.Capacidade <= Count)
            {
                return false;
            }

            return true;
        }
    }
}
