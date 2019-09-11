namespace Model
{
    public class Itempedido
    {
        private int codigo;
        private int qtde;
        private double valorunid;
        private Produto produto;
        private Pedido pedido;

        public Itempedido(int codigo, int qtde, double valorunid, Produto produto, Pedido pedido)
        {
            this.Codigo = codigo;
            this.Qtde = qtde;
            this.Valorunid = valorunid;
            this.Produto = produto;
            this.Pedido = pedido;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public int Qtde { get => qtde; set => qtde = value; }
        public double Valorunid { get => valorunid; set => valorunid = value; }
        public Produto Produto { get => produto; set => produto = value; }
        public Pedido Pedido { get => pedido; set => pedido = value; }

    }
}
