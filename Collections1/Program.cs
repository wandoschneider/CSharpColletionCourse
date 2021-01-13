using System;

namespace Collections1
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "1. Introdução às coleções";
            string aulaModelando = "2. Modelando a Classe Aula";
            string aulaSets = "3. Trabalhando com Conjuntos";

            // string[] aulas = new string[]
            // {
            //     aulaIntro,
            //     aulaModelando,
            //     aulaSets
            // };

            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Imprimir(aulas);

            System.Console.WriteLine(aulas[0]);
            System.Console.WriteLine(aulas.Length - 1);

            aulaIntro = "Trabalhando com Arrays";
            Imprimir(aulas);

            aulas[0] = "1. Trabalhando com Arrays";
            Imprimir(aulas);

            System.Console.WriteLine($"Aula Modelando está no índice: {Array.IndexOf(aulas, aulaModelando)}");
            System.Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            Array.Sort(aulas);
            Imprimir(aulas);

            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);

            string[] clone = aulas.Clone() as string[];
            Imprimir(copia);

            Array.Clear(clone, 1, 2);
            Imprimir(clone);
        }

        private static void Imprimir(string[] aulas)
        {
            // foreach (var aula in aulas)
            // {
            //     System.Console.WriteLine(aula);
            // }
            System.Console.WriteLine("--------------------------------");
            for (int i = 0; i < aulas.Length; i++)
            {
                System.Console.WriteLine(aulas[i]);

            }
        }
    }
}
