using System.Collections.Generic;

namespace Model
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private double valor;
        private List<Estoque> estoques;

        public Produto(int codigo, string nome, double valor)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Valor = valor;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
        public List<Estoque> Estoques { get => estoques; set => estoques = value; }
    }
}
