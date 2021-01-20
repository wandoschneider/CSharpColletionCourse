using System;

namespace SetsOnModel
{
    class Program
    {
        static void Main(string[] args)
        {
            var csharpColecoes = new Curso("C# Coleções", "Instrutor da Porra");

            csharpColecoes.Adicionar(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adicionar(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adicionar(new Aula("Modelando Coleções", 24));

            var a1 = new Aluno("Vanessa Tonini", 1234);
            var a2 = new Aluno("Ana Losnak", 5617);
            var a3 = new Aluno("Rafale Nercessian", 4132);

            csharpColecoes.Matricular(a1);
            csharpColecoes.Matricular(a2);
            csharpColecoes.Matricular(a3);
            System.Console.WriteLine("Imprimindo Alunos Matriculados:");

            foreach (var aluno in csharpColecoes.Alunos)
            {
                System.Console.WriteLine(aluno);
            }

            System.Console.WriteLine($"O Aluno {a1} está matriculado?");
            System.Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            var tonini = new Aluno("Vanessa Tonini", 1234);
            System.Console.WriteLine(a1.Equals(tonini));

            Console.Clear();
            var aluno5617 = csharpColecoes.BuscaMatriculado(5617);
            System.Console.WriteLine($"aluno5617: {aluno5617}");

            var fabio = new Aluno("Fabio Duplicado", 5617);
            csharpColecoes.SubstituirAluno(fabio);
            System.Console.WriteLine($"Quem possui a matrícula 5617? {csharpColecoes.BuscaMatriculado(5617)}");

        }
    }
}
