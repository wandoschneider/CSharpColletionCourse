using System;

namespace SetsOnModel
{
    public class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public override string ToString()
        {
            return $"[Título: {titulo}, tempo: {tempo} minutos]";
        }

        public int CompareTo(object obj)
        {
            Aula that = obj as Aula;
            return this.titulo.CompareTo(that.Titulo);
        }
    }
}