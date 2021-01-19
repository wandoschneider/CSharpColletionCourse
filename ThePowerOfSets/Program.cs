using System;
using System.Collections.Generic;

namespace ThePowerOfSets
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<string> alunos = new HashSet<string>();
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafal Nercessian");
            System.Console.WriteLine(string.Join(", ", alunos));

            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            System.Console.WriteLine(string.Join(", ", alunos));

            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            System.Console.WriteLine(string.Join(", ", alunos));
            
            alunos.Add("Fabio Gushiken");
            System.Console.WriteLine(string.Join(", ", alunos));

            var alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            System.Console.WriteLine(string.Join(", ", alunosEmLista));
        }
    }
}
