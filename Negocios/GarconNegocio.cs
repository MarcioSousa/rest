using Control;
using Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocios
{
    public class GarconNegocio
    {
        readonly DQL consulta = new DQL();
        readonly DML manipulacao = new DML();

        public string Inserir(Garcon garcon)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "INSERT INTO garcon(codigo, nome) VALUES(" + garcon.Codigo + ", '" + garcon.Nome + "')").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(Garcon garcon, int codigoantigo)
        {
            try
            {
                if (codigoantigo == garcon.Codigo)
                {
                    return manipulacao.ExecutarManipulacao(CommandType.Text, "UPDATE garcon SET nome = '" + garcon.Nome + "' WHERE codigo = " + garcon.Codigo).ToString();
                }
                else
                {
                    return manipulacao.ExecutarManipulacao(CommandType.Text, "UPDATE garcon SET codigo = " + garcon.Codigo + ", nome = '" + garcon.Nome + "' WHERE codigo = " + codigoantigo).ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(int codigogarcon)
        {
            try
            {
                return manipulacao.ExecutarManipulacao(CommandType.Text, "DELETE FROM garcon WHERE codigo = " + codigogarcon).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Garcon> TodosGarcon()
        {
            try
            {
                List<Garcon>    garcons = new List<Garcon>();

                DataTable dataTableProduto = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome FROM garcon");

                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    Garcon garcon = new Garcon(Convert.ToInt32(linha["codigo"]), linha["nome"].ToString());
                    garcons.Add(garcon);
                }

                return garcons;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar os Produtos.\nDetalhes: " + ex.Message);
            }
        }
        public List<Garcon> ProcurarPorCodigoOuNome(int codGarcon, string parteNome)
        {
            try
            {
                List<Garcon> garcons = new List<Garcon>();
                DataTable dataTableGarcons = new DataTable();

                if (codGarcon != 0)
                {
                    dataTableGarcons = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome FROM garcon WHERE codigo = " + codGarcon);
                }
                else
                {
                    dataTableGarcons = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome FROM garcon WHERE nome LIKE '%" + parteNome + "%'");
                }

                foreach (DataRow linha in dataTableGarcons.Rows)
                {
                    Garcon garcon = new Garcon(Convert.ToInt32(linha["codigo"]), linha["nome"].ToString());
                    garcons.Add(garcon);
                }

                return garcons;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Garcon ProcurarPorCodigo(int codGarcon)
        {
            try
            {
                DataTable dataTableGarcons = new DataTable();

                dataTableGarcons = consulta.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome FROM garcon WHERE codigo = " + codGarcon);

                Garcon garcon = new Garcon(Convert.ToInt32(dataTableGarcons.Rows[0]["codigo"]), dataTableGarcons.Rows[0]["nome"].ToString());

                return garcon;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
