namespace SetsOnModel
{
    public class Aluno
    {
        private string nome;
        private int numeroMatricula;
        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {NumeroMatricula}]";
        }

        public override bool Equals(object obj)
        {
            var outro = obj as Aluno;
            if (outro != null)
                return this.nome.Equals(outro.nome);
            
            return false;
        }

        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }
    }
}