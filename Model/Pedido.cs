using System;
using System.Collections.Generic;

namespace Model
{
    public class Pedido
    {
        private int codigo;
        private DateTime datahorapedido;
        private int numeromesa;
        private string disponivel;
        private List<Itempedido> itempedidos;
        private Garcon garcon;
        private List<Pagamento> pagamentos;

        public Pedido(int codigo, DateTime datahorapedido, int numeromesa, string disponivel, Garcon garcon)
        {
            this.Codigo = codigo;
            this.Datahorapedido = datahorapedido;
            this.Numeromesa = numeromesa;
            this.Disponivel = disponivel;
            this.Garcon = garcon;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime Datahorapedido { get => datahorapedido; set => datahorapedido = value; }
        public int Numeromesa { get => numeromesa; set => numeromesa = value; }
        public string Disponivel { get => disponivel; set => disponivel = value; }
        public List<Itempedido> Itempedidos { get => itempedidos; set => itempedidos = value; }
        public Garcon Garcon { get => garcon; set => garcon = value; }
        public List<Pagamento> Pagamentos { get => pagamentos; set => pagamentos = value; }
    }
}
