using System;
using System.Collections.Generic;

namespace ObjectsList
{
    class Program
    {
        static void Main(string[] args)
        {
            var aulaIntro = new Aula("1. Introdução às coleções", 20);
            var aulaModelando = new Aula("2. Modelando a Classe Aula", 18);
            var aulaSets = new Aula("3. Trabalhando com Conjuntos", 16);

            var aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);

            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(aulas);

        }

        private static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();

            foreach (var aula in aulas)
            {
                System.Console.WriteLine(aula);
            }
        }

        class Aula : IComparable
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
}
