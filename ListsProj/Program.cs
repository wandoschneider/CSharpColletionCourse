using System;
using System.Collections.Generic;

namespace ListsProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "1. Introdução às coleções";
            string aulaModelando = "2. Modelando a Classe Aula";
            string aulaSets = "3. Trabalhando com Conjuntos";

            // var aulas = new List<string>
            // {
            //     aulaIntro,
            //     aulaModelando,
            //     aulaSets
            // };

            var aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);
        }

        private static void Imprimir(List<string> aulas)
        {
            System.Console.WriteLine("------------------------------------");

            // foreach (var aula in aulas)
            // {
            //     System.Console.WriteLine(aula);
            // }

            // for (int i = 0; i < aulas.Count; i++)
            // {
            //     System.Console.WriteLine(aulas[i]);
            // }

            aulas.ForEach(aula => {System.Console.WriteLine(aula);});
        }
    }
}
