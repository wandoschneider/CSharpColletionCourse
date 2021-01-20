using System;
using System.Collections.Generic;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var frutas = new List<string>
            {
                "abacate", "banana", "caqui", "damasco", "figo"
            };

            foreach (var fruta in frutas)
            {
                System.Console.WriteLine(fruta);
            }

            var dias = new LinkedList<string>();

            var d4 = dias.AddFirst("quarta");
            var d2 = dias.AddBefore(d4, "segunda");
            var d3 = dias.AddAfter(d2, "terça");
            var d6 = dias.AddAfter(d4, "sexta");
            var d7 = dias.AddAfter(d6, "sábado");
            var d5 = dias.AddBefore(d6, "quinta");
            var d1 = dias.AddBefore(d2, "domingo");

            foreach (var dia in dias)
            {
                System.Console.WriteLine(dia);
            }


        }
    }
}
