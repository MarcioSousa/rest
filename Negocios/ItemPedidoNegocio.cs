using Control;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocios
{
    public class ItemPedidoNegocio
    {
        readonly DQL consulta = new DQL();
        readonly DML manipulacao = new DML();

        public string Inserir(Itempedido itempedido)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "INSERT INTO itempedido(codproduto, codpedido, qtde, valorunid) VALUES(" + itempedido.Produto.Codigo + "," + itempedido.Pedido.Codigo + "," + itempedido.Qtde + "," + itempedido.Valorunid.ToString().Replace(",", ".") + ")").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(int  coditempedido)
        {
            try
            {
                manipulacao.ExecutarManipulacao(CommandType.Text, "DELETE FROM itempedido WHERE codigo = " + coditempedido);
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Itempedido> itempedidos(Pedido pedido)
        {
            try
            {
                List<Itempedido> itempedidos = new List<Itempedido>();
                ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();
                ProdutoNegocio produtoNegocio = new ProdutoNegocio();

                DataTable dataTableItemPedido = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, codproduto, codpedido, qtde, valorunid FROM itempedido WHERE codpedido = " + pedido.Codigo);

                foreach (DataRow linha in dataTableItemPedido.Rows)
                {
                    Itempedido itempedido = new Itempedido(Convert.ToInt32(linha["codigo"]), Convert.ToInt32(linha["qtde"]), Convert.ToDouble(linha["valorunid"]), produtoNegocio.ProdutoItemPedido(Convert.ToInt32(linha["codproduto"])), pedido);
                    itempedidos.Add(itempedido);
                }

                return itempedidos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Pedidos.\nDetalhes: " + ex.Message);
            }
        }
        public double TotalItemPedido(int codigopedido)
        {
            try
            {
                ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();

                double totalValorPedido = 0;

                DataTable dataTablePagamento = consulta.ExecutarConsulta(CommandType.Text, "SELECT qtde, valorunid FROM itempedido WHERE codpedido = " + codigopedido);

                foreach (DataRow linha in dataTablePagamento.Rows)
                {
                    totalValorPedido += Convert.ToInt32(linha["qtde"]) * Convert.ToDouble(linha["valorunid"]);
                }

                return totalValorPedido;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public int QtdeSaida(int codproduto)
        {
            try
            {
                ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();

                int qtdeSaida = 0;

                DataTable dataTableSaida = consulta.ExecutarConsulta(CommandType.Text, "SELECT SUM(qtde) AS total FROM itempedido WHERE codproduto = " + codproduto);

                if (dataTableSaida.Rows[0]["total"].ToString() != "")
                {
                    qtdeSaida = Convert.ToInt32(dataTableSaida.Rows[0]["total"]);
                }

                return qtdeSaida;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível fazer a soma de saída dos Produtos.\nDetalhes: " + ex.Message);
            }
        }
    }
}