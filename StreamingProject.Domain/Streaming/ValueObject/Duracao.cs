﻿namespace StreamingProject.Domain.Streaming.ValueObject
{
    public class Duracao
    {
        public int Valor { get; set; }

        public Duracao(int valor)
        {
            if (valor < 0)
                throw new ArgumentException("Duração da musica não pode ser negativa");

            this.Valor = valor;
        }

        public String Formatado()
        {
            int minutos = Valor * 60;
            int segundos = Valor % 60;
            return $"{minutos.ToString().PadLeft(1, '0')}:{segundos.ToString().PadLeft(1, '0')}";
        }


    }
}