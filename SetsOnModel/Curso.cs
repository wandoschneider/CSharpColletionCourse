using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SetsOnModel
{
    public class Curso
    {
        private Dictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }
        private IList<Aula> aulas;
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        internal void Adicionar(Aula aula)
        {
            this.aulas.Add(aula);
        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        internal void Matricular(Aluno aluno)
        {
            this.alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        internal void SubstituirAluno(Aluno aluno)
        {
            this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
        }

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {

            Aluno aluno = null;
            this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
            return aluno;

            //Busca feita na unha
            // foreach (var aluno in alunos)
            // {
            //     if (aluno.NumeroMatricula == numeroMatricula)
            //         return aluno;

            // }

            // throw new Exception($"Matrícula não encontrada ({numeroMatricula})");
        }

        public int TempoTotal
        {
            get
            {
                // int total = 0;
                // foreach (var aula in aulas)
                // {
                //     total += aula.Tempo;
                // }
                // return total;
                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(", ", aulas)}";
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }
    }
}