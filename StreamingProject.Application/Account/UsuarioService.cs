using StreamingProject.Application.Account.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingProject.Application.Account
{
    public class UsuarioService
    {
        public CriarUsuarioDTO CriarUsuario (CriarUsuarioDTO dto)
        {
            //Todo pegar cartao do banco
            //Cartao cartao = pegar cartao pelo usuario

            //Todo pegar plano por id:
            //Plano plano = //ir ao banco e pegar por id

            //Usuario usuario = new Usuario();
            //usuario.Criar(dto.Nome, dto.CPF, Plano, Cartao);

            //Gravar Usuario do banco de dados

            return new CriarUsuarioDTO
            {

            };
        }
    }
}
