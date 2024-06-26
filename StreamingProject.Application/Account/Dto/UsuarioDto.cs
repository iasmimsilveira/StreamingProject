﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingProject.Application.Account.Dto
{
    public class UsuarioDto
    {
        public Guid Id { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public String CPF { get; set; }

        [Required]
        public Guid PlanoId { get; set; }

        public CartaoDto Cartao { get; set; }
    }

    public class CartaoDto
    {
        [Required]
        public String Numero { get; set; }

        [Required]
        public Decimal Limite { get; set; }

        [Required]
        public Boolean Ativo { get; set; }
    }
}
