using System.Collections.Generic;

namespace Model
{
    public class Garcon
    {
        private int codigo;
        private string nome;
        private List<Pedido> pedidos;

        public Garcon(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }
    }
}
