using Control;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocios
{
    public class EstoqueNegocio
    {
        readonly DQL consulta = new DQL();
        readonly DML manipulacao = new DML();

        public string Inserir(Estoque estoque)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "INSERT INTO estoque(codproduto, dataentrada, datavencimento, valortotal, qtde) VALUES(" + estoque.Produto.Codigo + ", '" + estoque.Dataentrada.ToString("yyyy/MM/dd") + "', '" + estoque.Datavencimento.ToString("yyyy/MM/dd") + "'," + estoque.Valortotal.ToString().Replace(",", ".") + "," + estoque.Qtde + ")").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(Estoque estoque)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "UPDATE estoque SET codproduto = " + estoque.Produto.Codigo + ", dataentrada = '" + estoque.Dataentrada.ToString("yyyy/MM/dd") + "', datavencimento = '" + estoque.Datavencimento.ToString("yyyy/MM/dd") + "', valortotal = " + estoque.Valortotal.ToString().Replace(",", ".") + ", qtde = " + estoque.Qtde + " WHERE codigo = " + estoque.Codigo).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(int codigoestoque)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "DELETE FROM estoque WHERE codigo = " + codigoestoque).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Estoque> TodosEstoque()
        {
            try
            {
                List<Estoque> estoques = new List<Estoque>();
                ProdutoNegocio produtoNegocio = new ProdutoNegocio();

                DataTable dataTableEstoque = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, codproduto, dataentrada, datavencimento, valortotal, qtde FROM estoque");

                foreach (DataRow linha in dataTableEstoque.Rows)
                {
                    Estoque estoque = new Estoque(Convert.ToInt32(linha["codigo"]), Convert.ToDateTime(linha["dataentrada"]), Convert.ToDateTime(linha["datavencimento"]), Convert.ToDouble(linha["valortotal"]), Convert.ToInt32(linha["qtde"]), produtoNegocio.ProdutoEstoque(Convert.ToInt32(linha["codproduto"])));
                    estoques.Add(estoque);
                }

                return estoques;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public List<Estoque> EstoquesProduto(int codigoproduto)
        {
            try
            {
                List<Estoque> estoques = new List<Estoque>();
                ProdutoNegocio produtoNegocio = new ProdutoNegocio();

                DataTable dataTableEstoque = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, codproduto, dataentrada, datavencimento, valortotal, qtde FROM estoque WHERE codproduto = " + codigoproduto + " ORDER BY dataentrada DESC");

                foreach (DataRow linha in dataTableEstoque.Rows)
                {
                    Estoque estoque = new Estoque(Convert.ToInt32(linha["codigo"]), Convert.ToDateTime(linha["dataentrada"]), Convert.ToDateTime(linha["datavencimento"]), Convert.ToDouble(linha["valortotal"]), Convert.ToInt32(linha["qtde"]), produtoNegocio.ProdutoEstoque(Convert.ToInt32(linha["codproduto"])));
                    estoques.Add(estoque);
                }

                return estoques;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public List<Estoque> PesquisaEstoqueEntradaVencimento(bool dataEntrada, bool dataVencimento, int mes, int ano)
        {
            try
            {
                List<Estoque> estoques = new List<Estoque>();
                ProdutoNegocio produtoNegocio = new ProdutoNegocio();

                DataTable dataTableEstoque = new DataTable();

                if (dataEntrada)
                {
                    dataTableEstoque = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, codproduto, dataentrada, datavencimento, valortotal, qtde FROM estoque WHERE MONTH(dataentrada) = " + mes + " AND YEAR(dataentrada) = " + ano + " ORDER BY dataentrada DESC");
                }
                else
                {
                    dataTableEstoque = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, codproduto, dataentrada, datavencimento, valortotal, qtde FROM estoque WHERE MONTH(datavencimento) = " + mes + " AND YEAR(datavencimento) = " + ano + " ORDER BY datavencimento DESC");
                }

                foreach (DataRow linha in dataTableEstoque.Rows)
                {
                    Estoque estoque = new Estoque(Convert.ToInt32(linha["codigo"]), Convert.ToDateTime(linha["dataentrada"]), Convert.ToDateTime(linha["datavencimento"]), Convert.ToDouble(linha["valortotal"]), Convert.ToInt32(linha["qtde"]), produtoNegocio.ProdutoEstoque(Convert.ToInt32(linha["codproduto"])));
                    estoques.Add(estoque);
                }

                return estoques;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public int QtdeEntrada(int codproduto)
        {
            try
            {
                EstoqueNegocio estoqueNegocio = new EstoqueNegocio();

                int qtdeEntrada = 0;

                DataTable dataTableEntrada = consulta.ExecutarConsulta(CommandType.Text, "SELECT SUM(qtde) AS total FROM estoque WHERE codproduto = " + codproduto);

                if (dataTableEntrada.Rows[0]["total"].ToString() != "")
                {
                    qtdeEntrada = Convert.ToInt32(dataTableEntrada.Rows[0]["total"]);
                }

                return qtdeEntrada;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível fazer a soma de entrada dos Produtos.\nDetalhes: " + ex.Message);
            }
        }
    }
}
