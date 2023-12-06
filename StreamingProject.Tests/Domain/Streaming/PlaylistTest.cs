using StreamingProject.Domain.Account.Aggregates;
using StreamingProject.Domain.Streaming.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingProject.Tests.Domain.Streaming
{
    public class PlaylistTest
    {

        [Fact]
        public void DeveCriarPlaylistComSucesso()
        {
            // Arrange
            var id = Guid.NewGuid();
            var nomePlaylist = "Minha Playlist";
            var usuario = new Usuario();
            var playlist = new Playlist
            {
                Id = id,
                Nome = nomePlaylist,
                Publica = false,
                Usuario = usuario,
            };

            Assert.Equal(id, playlist.Id);
            Assert.Equal(nomePlaylist, playlist.Nome);
            Assert.False(playlist.Publica);
            Assert.Same(usuario, playlist.Usuario);
            Assert.Empty(playlist.Musicas);
        }


    }
}
