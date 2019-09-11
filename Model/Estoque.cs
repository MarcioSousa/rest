using System;

namespace Model
{
    public class Estoque
    {
        private int codigo;
        private DateTime dataentrada;
        private DateTime datavencimento;
        private double valortotal;
        private int qtde;
        private Produto produto;

        public Estoque(int codigo, DateTime dataentrada, DateTime datavencimento, double valortotal, int qtde, Produto produto)
        {
            this.Codigo = codigo;
            this.Dataentrada = dataentrada;
            this.Datavencimento = datavencimento;
            this.Valortotal = valortotal;
            this.Qtde = qtde;
            this.Produto = produto;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime Dataentrada { get => dataentrada; set => dataentrada = value; }
        public DateTime Datavencimento { get => datavencimento; set => datavencimento = value; }
        public double Valortotal { get => valortotal; set => valortotal = value; }
        public int Qtde { get => qtde; set => qtde = value; }
        public Produto Produto { get => produto; set => produto = value; }
    }
}
