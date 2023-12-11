using StreamingProject.Streaming.Domain.ValueObject;

namespace StreamingProject.Streaming.Domain.Aggregates
{
    public class Musica
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Duracao Duracao { get; set; }

        public Album Album { get; set; }
    }
}