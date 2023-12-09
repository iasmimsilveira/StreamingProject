using StreamingProject.Domain.Account.Aggregates;

namespace StreamingProject.Domain.Streaming.Aggregates
{
    public class Playlist
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Boolean Publica { get; set; }
        public Usuario Usuario { get; set; }
        public List<Musica> Musicas { get; set; }

        public Playlist()
        {
            Musicas = new List<Musica>();
        }
    }
}