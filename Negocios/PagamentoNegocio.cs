using Control;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocios
{
    public class PagamentoNegocio
    {
        readonly DQL consulta = new DQL();
        readonly DML manipulacao = new DML();

        public string Inserir(Pagamento pagamento)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "INSERT INTO pagamento(codpedido, datahorapagamento, tipo, valor) VALUES(" + pagamento.Pedido.Codigo + ", '" + pagamento.Datahorapagamento.ToString("yyyy/MM/dd HH:mm") + "', '" + pagamento.Tipo + "', " + pagamento.Valor.ToString().Replace(",", ".") + ")").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(Pagamento pagamento)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "UPDATE pagamento SET codpedido = " + pagamento.Pedido.Codigo + ", datahorapagamento = '" + pagamento.Datahorapagamento.ToString("yyyy/MM/dd HH:mm") + "', tipo = '" + pagamento.Tipo + "', valor = " + pagamento.Valor.ToString().Replace(",", ".") + " WHERE codigo = " + pagamento.Codigo).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(int codigopagamento)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "DELETE FROM pagamento WHERE codigo = " + codigopagamento).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Pagamento> PagamentosPedido(Pedido pedido)
        {
            try
            {
                List<Pagamento> pagamentos = new List<Pagamento>();

                DataTable dataTablePagamento = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, codpedido, datahorapagamento, tipo, valor FROM pagamento WHERE codpedido = " + pedido.Codigo);

                foreach(DataRow linha in dataTablePagamento.Rows)
                {
                    Pagamento pagamento = new Pagamento(Convert.ToInt32(linha["codigo"]), Convert.ToDateTime(linha["datahorapagamento"]), linha["tipo"].ToString(), Convert.ToDouble(linha["valor"]), pedido);
                    pagamentos.Add(pagamento);
                }

                return pagamentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public double TotalPagamento(DateTime datapagamento)
        {
            try
            {
                double totalPagamento = 0;

                DataTable dataTablePagamento = consulta.ExecutarConsulta(CommandType.Text, "SELECT valor FROM pagamento WHERE DAY(datahorapagamento) = " + datapagamento.Date.Day + " AND MONTH(datahorapagamento) = " + datapagamento.Date.Month + " AND YEAR(datahorapagamento) = " + datapagamento.Date.Year);

                foreach (DataRow linha in dataTablePagamento.Rows)
                {
                    totalPagamento += Convert.ToDouble(linha["valor"]);
                }
                return totalPagamento;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public double TotalPagamentoTipo(DateTime datapagamento, string tipo)
        {
            try
            {
                double totalPagamento = 0;

                DataTable dataTablePagamento = consulta.ExecutarConsulta(CommandType.Text, "SELECT valor FROM pagamento WHERE DAY(datahorapagamento) = " + datapagamento.Date.Day + " AND MONTH(datahorapagamento) = " + datapagamento.Date.Month + " AND YEAR(datahorapagamento) = " + datapagamento.Date.Year + " AND tipo = '" + tipo + "'");

                foreach (DataRow linha in dataTablePagamento.Rows)
                {
                    totalPagamento += Convert.ToDouble(linha["valor"]);
                }
                return totalPagamento;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public List<Pagamento> PagamentosData(DateTime datapagamento)
        {
            try
            {
                PedidoNegocio pedidoNegocio = new PedidoNegocio();
                List<Pagamento> pagamentos = new List<Pagamento>();

                DataTable dataTablePagamento = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, codpedido, datahorapagamento, tipo, valor FROM pagamento WHERE DAY(datahorapagamento) = " + datapagamento.Date.Day + " AND MONTH(datahorapagamento) = " + datapagamento.Date.Month + " AND YEAR(datahorapagamento) = " + datapagamento.Date.Year);

                foreach (DataRow linha in dataTablePagamento.Rows)
                {
                    Pagamento pagamento = new Pagamento(Convert.ToInt32(linha["codigo"]), Convert.ToDateTime(linha["datahorapagamento"]), linha["tipo"].ToString(), Convert.ToDouble(linha["valor"]), pedidoNegocio.PedidoPagamento(Convert.ToInt32(linha["codpedido"])));
                    pagamentos.Add(pagamento);
                }
                return pagamentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
    }
}
