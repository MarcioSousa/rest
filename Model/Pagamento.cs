using System;

namespace Model
{
    public class Pagamento
    {
        private int codigo;
        private DateTime datahorapagamento;
        private string tipo;
        private double valor;
        private Pedido pedido;

        public Pagamento(int codigo, DateTime datahorapagamento, string tipo, double valor, Pedido pedido)
        {
            this.Codigo = codigo;
            this.Datahorapagamento = datahorapagamento;
            this.Tipo = tipo;
            this.Valor = valor;
            this.Pedido = pedido;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime Datahorapagamento { get => datahorapagamento; set => datahorapagamento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double Valor { get => valor; set => valor = value; }
        public Pedido Pedido { get => pedido; set => pedido = value; }
    }
}
