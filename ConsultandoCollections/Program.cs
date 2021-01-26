using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsultandoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            var consulta = seq1.Concat(seq2);
            foreach (var item in consulta)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine();

            var consulta2 = seq1.Union(seq2);
            foreach (var item in consulta)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine();

            System.Console.WriteLine("Union ignorando case:");
            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta3)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine();

            //ComecandoComLinq();
        }

        private static void ComecandoComLinq()
        {
            var meses = new List<Mes>
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Março", 31),
                new Mes("Abril", 30),
                new Mes("Maio", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Agosto", 31),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31)
            };

            // meses.Sort();
            // foreach (var mes in meses)
            // {
            //     if (mes.Dias == 31)
            //         System.Console.WriteLine(mes.Nome.ToUpper());
            // }

            IEnumerable<string>
                consulta = meses
                        .Where(m => m.Dias == 31)
                        .OrderBy(m => m.Nome)
                        .Select(m => m.Nome.ToUpper());

            foreach (var item in consulta)
            {
                System.Console.WriteLine(item);
            }
        }

        class Mes //: IComparable
        {
            public Mes(string nome, int dias)
            {
                Nome = nome;
                Dias = dias;
            }
            public string Nome { get; private set; }
            public int Dias { get; private set; }

            // public int CompareTo(object obj)
            // {
            //     Mes outro = obj as Mes;
            //     return this.Nome.CompareTo(outro.Nome);
            // }

            public override string ToString()
            {
                return $"{Nome} - {Dias}";
            }

        
        }
    }
}
