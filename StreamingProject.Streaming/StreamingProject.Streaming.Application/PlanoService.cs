using StreamingProject.Streaming.Application.Dto;
using StreamingProject.Streaming.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingProject.Streaming.Application
{
    public class PlanoService
    {
        private PlanoRepository PlanoRepository { get; set; }
        public PlanoService()
        {
            this.PlanoRepository = new PlanoRepository();
        }

        public PlanoDto ObterPlano(Guid id)
        {
            var plano = this.PlanoRepository.ObterPlanoPorId(id);

            if (plano == null)
                return null;

            return new PlanoDto()
            {
                Descricao = plano.Descricao,
                Id = plano.Id,
                Nome = plano.Nome,
                Valor = plano.Valor,
            };

        }
    }
}

