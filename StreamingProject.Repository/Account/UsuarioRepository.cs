﻿using StreamingProject.Domain.Account.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingProject.Repository.Account
{
    public class UsuarioRepository
    {

        private static List<Usuario> usuarios = new List<Usuario>();

        public Usuario ObterUsuario(Guid id)
        {
            return UsuarioRepository
                        .usuarios
                        .FirstOrDefault(x => x.Id == id);
        }

        public void SalvarUsuario(Usuario usuario)
        {
            usuario.Id = Guid.NewGuid();
            UsuarioRepository.usuarios.Add(usuario);
        }

        public void Update(Usuario usuario) 
        {
            Usuario usuarioOld = this.ObterUsuario(usuario.Id);
            UsuarioRepository.usuarios.Remove(usuarioOld);
            UsuarioRepository.usuarios.Add(usuario);
        }
    }
}
