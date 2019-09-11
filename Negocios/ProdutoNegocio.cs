using Control;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocios
{
    public class ProdutoNegocio
    {
        readonly DQL consulta = new DQL();
        readonly DML manipulacao = new DML();

        public string Inserir(Produto produto)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "INSERT INTO PRODUTO(codigo, nome, valor) VALUES(" + produto.Codigo + ", '" + produto.Nome + "', " + produto.Valor.ToString().Replace(",", ".") + ")").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(Produto produto, int codigoantigo)
        {
            try
            {
                if (codigoantigo == produto.Codigo)
                {
                    return manipulacao.ExecutarManipulacao(CommandType.Text, "UPDATE PRODUTO SET nome = '" + produto.Nome + "', valor = " + produto.Valor.ToString().Replace(",", ".") + " WHERE codigo = " + produto.Codigo).ToString();
                }
                else
                {
                    return manipulacao.ExecutarManipulacao(CommandType.Text, "UPDATE PRODUTO SET codigo = " + produto.Codigo + ", nome = '" + produto.Nome + "', valor = " + produto.Valor.ToString().Replace(",", ".") + " WHERE codigo = " + codigoantigo).ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(int codigoproduto)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "DELETE FROM produto WHERE codigo = " + codigoproduto).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Produto> TodosProduto()
        {
            try
            {
                List<Produto> produtos = new List<Produto>();

                DataTable dataTableProduto = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome, valor FROM produto");

                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    Produto produto = new Produto(Convert.ToInt32(linha["codigo"]), linha["nome"].ToString(), Convert.ToDouble(linha["valor"]));
                    produtos.Add(produto);
                }

                return produtos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public List<Produto> ProcurarPorCodigoOuNome(int codProduto, string parteNome)
        {
            try
            {
                List<Produto> produtos = new List<Produto>();
                DataTable dataTableProdutos = new DataTable();

                if (codProduto != 0)
                {
                    dataTableProdutos = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome, valor FROM produto WHERE codigo = " + codProduto);
                }
                else
                {
                    dataTableProdutos = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome, valor FROM produto WHERE nome LIKE '%" + parteNome + "%'");
                }

                foreach (DataRow linha in dataTableProdutos.Rows)
                {
                    Produto produto = new Produto(Convert.ToInt32(linha["codigo"]), linha["nome"].ToString(), Convert.ToDouble(linha["valor"]));
                    produtos.Add(produto);
                }

                return produtos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Produto ProdutoEstoque(int codProduto)
        {
            try
            {
                DataTable dataTableProdutos = new DataTable();

                dataTableProdutos = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome, valor FROM produto WHERE codigo = " + codProduto);

                Produto produto = new Produto(Convert.ToInt32(dataTableProdutos.Rows[0]["codigo"]), dataTableProdutos.Rows[0]["nome"].ToString(),Convert.ToDouble(dataTableProdutos.Rows[0]["valor"]));

                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Produto ProdutoItemPedido(int codProduto)
        {
            try
            {
                DataTable dataTableProdutos = new DataTable();

                dataTableProdutos = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome, valor FROM produto WHERE codigo = " + codProduto);

                Produto produto = new Produto(Convert.ToInt32(dataTableProdutos.Rows[0]["codigo"]), dataTableProdutos.Rows[0]["nome"].ToString(), Convert.ToDouble(dataTableProdutos.Rows[0]["valor"]));

                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}