using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingProject.Application.Account.DTO
{
    public class CriarUsuarioDTO
    {
        public String Nome { get; set; }
        public string CPF  { get; set; }
        public CartaoDTO Cartao { get; set; }
        public PlanoDTO Plano { get; set; }
    }

    public class CartaoDTO
    {

    }
}
