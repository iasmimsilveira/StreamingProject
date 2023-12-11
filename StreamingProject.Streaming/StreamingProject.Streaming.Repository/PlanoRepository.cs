// No arquivo PlanoRepository.cs

using StreamingProject.Streaming.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StreamingProject.Streaming.Repository
{
    public class PlanoRepository
    {
        private static List<Plano> planos;

        public PlanoRepository()
        {
            if (planos == null)
            {
                planos = new List<Plano>();
                InicializarPlanos();
            }
        }

        private void InicializarPlanos()
        {
            planos.Add(new Plano()
            {
                Descricao = "Plano Básico",
                Nome = "Plano Básico Música",
                Valor = 20M,
                Id = new Guid("8D044595-D4A6-4E1A-9F09-DAB92205C71C")
            });

            planos.Add(new Plano()
            {
                Descricao = "Plano Premium",
                Nome = "Plano Premium Música",
                Valor = 50M,
                Id = new Guid("7C6A0E38-4F25-4D09-AF2C-2CFC1FBD6A93")
            });
        }

        public Plano ObterPlanoPorId(Guid idPlano)
        {
            return planos.FirstOrDefault(x => x.Id == idPlano);
        }
    }
}
