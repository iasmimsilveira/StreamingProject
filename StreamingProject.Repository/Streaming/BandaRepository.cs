using StreamingProject.Domain.Streaming.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingProject.Repository.Streaming
{
    public class BandaRepository
    {
        private static List<Banda> Bandas = new List<Banda>();

        public void Criar(Banda banda)
        {
            banda.Id = Guid.NewGuid();
            Bandas.Add(banda);
        }

        public Banda ObterBanda(Guid id)
        {
            return Bandas.FirstOrDefault(x => x.Id == id);
        }
    }
}
