using System;
using System.Collections.Generic;

namespace ReadOnlyLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var csharpColecoes = new Curso("C# Collections", "Nome do Instrutor");
            csharpColecoes.Adicionar(new Aula("Trabalhando com listas", 21));

            Imprimir(csharpColecoes.Aulas);

            csharpColecoes.Adicionar(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adicionar(new Aula("Modelando com coleções", 19));

            Imprimir(csharpColecoes.Aulas);

            var aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
            aulasCopiadas.Sort();

            Imprimir(aulasCopiadas);

            System.Console.WriteLine(csharpColecoes.TempoTotal);

            System.Console.WriteLine(csharpColecoes.ToString());
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();

            foreach (var aula in aulas)
            {
                System.Console.WriteLine(aula);
            }
        }
    }
}
