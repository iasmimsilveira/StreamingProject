﻿namespace StreamingProject.Streaming.Domain.Aggregates
{
    public class Banda
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }

        public List<Album> Albums { get; set; }
        public Banda()
        {
            this.Albums = new List<Album>();
        }

        public void AdicionarAlbum(Album album)
        {
            this.Albums.Add(album);
        }
    }
}