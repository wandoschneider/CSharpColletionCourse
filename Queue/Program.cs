using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            Enfileirar("Van");
            Enfileirar("Kombi");
            Enfileirar("Guincho");
            Enfileirar("Pickup");
            
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();

        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "Guincho")
                    System.Console.WriteLine("Guincho está fazendo o pagamento");

                var veiculo = pedagio.Dequeue();
                System.Console.WriteLine($"Saiu da Fila: {veiculo}");
                ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            System.Console.WriteLine($"Entrou na fila: {veiculo}");

            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            System.Console.WriteLine("FILA:");
            foreach (var v in pedagio)
            {
                System.Console.WriteLine(v);
            }
        }
    }
}
