using Control;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocios
{
    public class PedidoNegocio
    {
        readonly DQL consulta = new DQL();
        readonly DML manipulacao = new DML();
        public string Inserir(Pedido pedido)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "INSERT INTO pedido(codgarcon, numeromesa, datahorapedido, disponivel) VALUES(" + pedido.Garcon.Codigo + "," + pedido.Numeromesa + ",'" + pedido.Datahorapedido.ToString("yyyy/MM/dd HH:mm") + "','" + pedido.Disponivel + "');  SELECT @@IDENTITY;").ToString();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(Pedido pedido)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "UPDATE pedido SET codgarcon = " + pedido.Garcon.Codigo + ", numeromesa = " + pedido.Numeromesa + ", datahorapedido = '" + pedido.Datahorapedido.ToString("yyyy/MM/dd HH:mm") + "', disponivel = '" + pedido.Disponivel + "' WHERE codigo = " + pedido.Codigo).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string AlterarMesa(Pedido pedido)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "UPDATE pedido SET numeromesa = " + pedido.Numeromesa + " WHERE codigo = " + pedido.Codigo).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string FecharMesa(Pedido pedido)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "UPDATE pedido SET disponivel = '" + pedido.Disponivel + "' WHERE codigo = " + pedido.Codigo).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(int codigopedido)
        {
            try
            {
               return manipulacao.ExecutarManipulacao(CommandType.Text, "DELETE FROM pedido WHERE codigo = " + codigopedido).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Pedido> MesasOcupadas()
        {
            try
            {
                List<Pedido> pedidos = new List<Pedido>();
                ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();
                GarconNegocio garconNegocio = new GarconNegocio();

                DataTable dataTablePedido = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, codgarcon, numeromesa, datahorapedido, disponivel FROM pedido WHERE disponivel = 'nao'");

                foreach (DataRow linha in dataTablePedido.Rows)
                {
                    Pedido pedido = new Pedido(Convert.ToInt32(linha["codigo"]), Convert.ToDateTime(linha["datahorapedido"]), Convert.ToInt32(linha["numeromesa"]), linha["disponivel"].ToString(), garconNegocio.ProcurarPorCodigo(Convert.ToInt32(linha["codgarcon"])));
                    pedidos.Add(pedido);
                }

                return pedidos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Pedidos.\nDetalhes: " + ex.Message);
            }
        }
        public List<Pedido> PedidosMesa(int mesa)
        {
            try
            {
                List<Pedido> pedidos = new List<Pedido>();
                GarconNegocio garconNegocio = new GarconNegocio();

                DataTable dataTablePedido = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, codgarcon, numeromesa, datahorapedido, disponivel FROM pedido WHERE numeromesa = " + mesa + " AND disponivel = 'nao'");

                foreach (DataRow linha in dataTablePedido.Rows)
                {
                    Pedido pedido = new Pedido(Convert.ToInt32(linha["codigo"]), Convert.ToDateTime(linha["datahorapedido"]), Convert.ToInt32(linha["numeromesa"]), linha["disponivel"].ToString(), garconNegocio.ProcurarPorCodigo(Convert.ToInt32(linha["codgarcon"])));
                    pedidos.Add(pedido);
                }

                return pedidos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Pedidos.\nDetalhes: " + ex.Message);
            }
        }
        public Pedido PedidoItemPedido(int codigoPedido)
        {
            try
            {
                GarconNegocio garconNegocio = new GarconNegocio();

                DataTable dataTablePedidos = new DataTable();

                dataTablePedidos = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, codgarcon, numeromesa, datahorapedido, disponivel FROM pedido WHERE codigo = " + codigoPedido);

                Pedido pedido = new Pedido(codigoPedido, Convert.ToDateTime(dataTablePedidos.Rows[0]["datahorapedido"]), Convert.ToInt32(dataTablePedidos.Rows[0]["numeromesa"]), dataTablePedidos.Rows[0]["disponivel"].ToString(), garconNegocio.ProcurarPorCodigo(Convert.ToInt32(dataTablePedidos.Rows[0]["codgarcon"])));

                return pedido;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public double TotalPedido(DateTime datapedido)
        {
            try
            {
                ItemPedidoNegocio itemPedidoNegocio = new ItemPedidoNegocio();

                double valorTotalPedido = 0;

                DataTable dataTablePagamento = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo FROM pedido WHERE DAY(datahorapedido) = " + datapedido.Date.Day + " AND MONTH(datahorapedido) = " + datapedido.Date.Month + " AND YEAR(datahorapedido) = " + datapedido.Date.Year);

                foreach (DataRow linha in dataTablePagamento.Rows)
                {
                    valorTotalPedido += itemPedidoNegocio.TotalItemPedido(Convert.ToInt32(linha["codigo"]));
                }

                return valorTotalPedido;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public Pedido PedidoPagamento(int codigoPedido)
        {
            try
            {
                GarconNegocio garconNegocio = new GarconNegocio();

                DataTable dataTablePedidos = new DataTable();

                dataTablePedidos = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, codgarcon, numeromesa, datahorapedido, disponivel FROM pedido WHERE codigo = " + codigoPedido);

                Pedido pedido = new Pedido(codigoPedido, Convert.ToDateTime(dataTablePedidos.Rows[0]["datahorapedido"]), Convert.ToInt32(dataTablePedidos.Rows[0]["numeromesa"]), dataTablePedidos.Rows[0]["disponivel"].ToString(), garconNegocio.ProcurarPorCodigo(Convert.ToInt32(dataTablePedidos.Rows[0]["codgarcon"])));

                return pedido;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pedido> PedidosData(DateTime datapedido)
        {
            try
            {
                List<Pedido> pedidos = new List<Pedido>();
                GarconNegocio garconNegocio = new GarconNegocio();

                DataTable dataTablePedido = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, codgarcon, numeromesa, datahorapedido, disponivel FROM pedido WHERE DAY(datahorapedido) = " + datapedido.Date.Day + " AND MONTH(datahorapedido) = " + datapedido.Date.Month + " AND YEAR(datahorapedido) = " + datapedido.Date.Year);

                foreach (DataRow linha in dataTablePedido.Rows)
                {
                    Pedido pedido = new Pedido(Convert.ToInt32(linha["codigo"]), Convert.ToDateTime(linha["datahorapedido"]), Convert.ToInt32(linha["numeromesa"]), linha["disponivel"].ToString(), garconNegocio.ProcurarPorCodigo(Convert.ToInt32(linha["codgarcon"])));
                    pedidos.Add(pedido);
                }

                return pedidos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Pedidos.\nDetalhes: " + ex.Message);
            }
        }
        public Pedido PesquisaPedido(int codigoPedido)
        {
            try
            {
                GarconNegocio garconNegocio = new GarconNegocio();

                DataTable dataTablePedidos = new DataTable();

                dataTablePedidos = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, codgarcon, numeromesa, datahorapedido, disponivel FROM pedido WHERE codigo = " + codigoPedido);

                Pedido pedido = new Pedido(codigoPedido, Convert.ToDateTime(dataTablePedidos.Rows[0]["datahorapedido"]), Convert.ToInt32(dataTablePedidos.Rows[0]["numeromesa"]), dataTablePedidos.Rows[0]["disponivel"].ToString(), garconNegocio.ProcurarPorCodigo(Convert.ToInt32(dataTablePedidos.Rows[0]["codgarcon"])));

                return pedido;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}
