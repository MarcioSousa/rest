using Control;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocios
{
    public class CaixaNegocio
    {
        readonly DQL consulta = new DQL();
        readonly DML manipulacao = new DML();
        public string Inserir(Caixa caixa)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "INSERT INTO caixa(datacaixa, valor) VALUES('" + caixa.Datacaixa.ToString("yyyy/MM/dd") + "', " + caixa.Valor.ToString().Replace(",", ".") + ")").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(Caixa caixa, DateTime dataantigo)
        {
            try
            {
                if (dataantigo == caixa.Datacaixa)
                {
                    return manipulacao.ExecutarManipulacao(CommandType.Text, "UPDATE caixa SET valor = " + caixa.Valor.ToString().Replace(",", ".") + " WHERE datacaixa = '" + caixa.Datacaixa.ToString("yyyy/MM/dd") + "'").ToString();
                }
                else
                {
                    return manipulacao.ExecutarManipulacao(CommandType.Text, "UPDATE caixa SET datacaixa = '" + caixa.Datacaixa.ToString("yyyy/MM/dd") + "', valor = " + caixa.Valor.ToString().Replace(",", ".") + " WHERE datacaixa = '" + dataantigo.ToString("yyyy/MM/dd") + "'").ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(DateTime datacaixa)
        {
            try
            {
                manipulacao.ExecutarManipulacao(CommandType.Text, "DELETE FROM caixa WHERE datacaixa = '" + datacaixa.ToString("yyyy/MM/dd") + "'");
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Caixa> TodosRegistros()
        {
            try
            {
                List<Caixa> caixas = new List<Caixa>();

                DataTable dataTableCaixa = consulta.ExecutarConsulta(CommandType.Text, "SELECT datacaixa, valor FROM caixa ORDER BY datacaixa DESC");

                foreach (DataRow linha in dataTableCaixa.Rows)
                {
                    Caixa caixa = new Caixa(Convert.ToDouble(linha["valor"]), Convert.ToDateTime(linha["datacaixa"]));
                    caixas.Add(caixa);
                }

                return caixas;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public List<Caixa> ProcurarPorData(DateTime dataCaixa)
        {
            try
            {
                List<Caixa> caixas = new List<Caixa>();
                DataTable dataTableCaixa = new DataTable();

                dataTableCaixa = consulta.ExecutarConsulta(CommandType.Text, "SELECT datacaixa, valor FROM caixa WHERE datacaixa = '" + dataCaixa.ToString("yyyy/MM/dd") + "'");

                if (dataTableCaixa.Rows.Count != 0)
                {
                    Caixa caixa = new Caixa(Convert.ToDouble(dataTableCaixa.Rows[0]["valor"]), Convert.ToDateTime(dataTableCaixa.Rows[0]["datacaixa"]));
                    caixas.Add(caixa);
                }

                return caixas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}


        //public List<Caixa> TodoRegistro()
        //{
        //    try
        //    {
        //        List<Caixa> caixas = new List<Caixa>();

        //        DataTable dataTableCaixa = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, cod_pedido, valortotal, datapagam, valorgarcon, troco FROM CAIXA ORDER BY codigo");

        //        //Faz um conjunto de coleção
        //        foreach (DataRow linha in dataTableCaixa.Rows)
        //        {
        //            Caixa caixa = new Caixa(Convert.ToInt32(linha["codigo"]),Convert.ToInt32(linha["cod_pedido"]),Convert.ToDouble(linha["valortotal"]),Convert.ToDateTime(linha["datapagam"]),Convert.ToInt32(linha["valorgarcon"]),Convert.ToDouble(linha["troco"]));
        //            caixas.Add(caixa);
        //        }

        //        return caixas;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Não foi possível carregar os itens de Caixa.\nDetalhes: " + ex.Message);
        //    }
        //}
        //public List<Caixa> PagamentosDia(DateTime dia)
        //{
        //    try
        //    {
        //        List<Caixa> caixas = new List<Caixa>();

        //        DataTable dataTableCaixa = consulta.ExecutarConsulta(CommandType.Text, "SELECT datapagam, valortotal, troco FROM caixa WHERE datapagam = '" + dia.ToString("yyyy/MM/dd") + "'");

        //        foreach (DataRow linha in dataTableCaixa.Rows)
        //        {
        //            Caixa caixa = new Caixa(0, 0, Convert.ToDouble(linha["valortotal"]), Convert.ToDateTime(linha["datapagam"]), 0, Convert.ToDouble(linha["troco"]));
        //            caixas.Add(caixa);
        //        }

        //        return caixas;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Não foi possível carregar os itens de Caixa.\nDetalhes: " + ex.Message);
        //    }
        //}
        //public List<Caixa> CarregaGrafico(int mes)
        //{
        //    try
        //    {
        //        List<Caixa> caixas = new List<Caixa>();

        //        DataTable dataTableCaixa = consulta.ExecutarConsulta(CommandType.Text, "SELECT datapagam, troco, valortotal, datepart(month, datapagam) AS Expr1 FROM caixa WHERE datepart(month, datapagam) = " + mes);

        //        foreach (DataRow linha in dataTableCaixa.Rows)
        //        {
        //            Caixa caixa = new Caixa(0, 0, Convert.ToDouble(linha["valortotal"]), Convert.ToDateTime(linha["datapagam"]), 0, Convert.ToDouble(linha["troco"]));
        //            caixas.Add(caixa);
        //        }

        //        return caixas;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Não foi possível carregar os itens de Caixa.\nDetalhes: " + ex.Message);
        //    }
        //}
        //public List<Caixa> Totais(DateTime dataAtual)
        //{
        //    try
        //    {
        //        List<Caixa> caixaColecao = new List<Caixa>();

        //        DataTable dataTableCaixa = consulta.ExecutarConsulta(CommandType.Text, "SELECT SUM(valortotal) As ValorTotal, SUM(troco) AS Troco FROM caixa WHERE datapagam = '" + dataAtual.Date + "'");

        //        foreach (DataRow linha in dataTableCaixa.Rows)
        //        {
        //            Caixa caixa = new Caixa(0, 0, 0, DateTime.Today.Date, 0, 0);

        //            if (linha["ValorTotal"] is DBNull)
        //            {
        //                caixa.Valortotal = 0;
        //                caixa.Troco = 0;
        //            }
        //            else
        //            {
        //                caixa.Valortotal = Convert.ToDouble(linha["ValorTotal"]);
        //                caixa.Troco = Convert.ToDouble(linha["troco"]);
        //            }
        //            caixaColecao.Add(caixa);
        //        }
        //        return caixaColecao;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Não foi possível carregar os itens de Caixa.\nDetalhes: " + ex.Message);
        //    }
        //}