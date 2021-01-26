using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");

            foreach (var aluno in alunos)
            {
                System.Console.WriteLine(aluno);
            }

            var outroConjunto = new HashSet<string>();

            alunos.IsSubsetOf(outroConjunto);
            alunos.IsSupersetOf(outroConjunto);
            alunos.SetEquals(outroConjunto);
            alunos.ExceptWith(outroConjunto);
            alunos.IntersectWith(outroConjunto);
            alunos.SymmetricExceptWith(outroConjunto);
            alunos.UnionWith(outroConjunto);

            // SortedDictionary();
            // SortedList();
        }

        static void SortedDictionary()
        {
            var alunosSorted = new SortedDictionary<string, Aluno>();

            alunosSorted.Add("VT", new Aluno("Vanessa", 34672));
            alunosSorted.Add("AL", new Aluno("Ana", 5617));
            alunosSorted.Add("RN", new Aluno("Rafael", 17645));
            alunosSorted.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var item in alunosSorted)
            {
                System.Console.WriteLine(item);
            }
        }

        static void SortedList()
        {
            var alunos = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var aluno in alunos)
            {
                System.Console.WriteLine(aluno);
            }

            var alunosSorted = new SortedList<string, Aluno>();

            alunosSorted.Add("VT", new Aluno("Vanessa", 34672));
            alunosSorted.Add("AL", new Aluno("Ana", 5617));
            alunosSorted.Add("RN", new Aluno("Rafael", 17645));
            alunosSorted.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var item in alunosSorted)
            {
                System.Console.WriteLine(item);
            }
        }
    }

    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
