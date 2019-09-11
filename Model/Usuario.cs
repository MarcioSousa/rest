namespace Model
{
    public  class Usuario
    {
        private int codigo;
        private string nome;
        private string senha;

        public Usuario(int codigo, string nome, string senha)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Senha = senha;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
