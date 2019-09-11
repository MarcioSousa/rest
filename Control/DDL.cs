using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Control
{
    public class DDL
    {
        private readonly SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
        private SqlConnection CriarConexaoSemBanco()
        {
            return new SqlConnection("Data Source=" + SystemInformation.ComputerName + "\\SQLEXPRESS;Integrated Security=True");
        }
        private SqlConnection CriarConexao()
        {
            return new SqlConnection("Data Source=" + SystemInformation.ComputerName + "\\SQLEXPRESS;Initial Catalog=cfsrestaurante;Integrated Security=True");
        }
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }
        public void AdicionarParametros(String nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }
        public int VerificandoBancoExiste(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            try
            {
                int qtde = 0;
                SqlConnection sqlConnection = CriarConexaoSemBanco();
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoreProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                qtde = Convert.ToInt32(dataTable.Rows[0]["qtde"].ToString());

                sqlConnection.Close();

                return qtde;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void CriarBancoDados(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexaoSemBanco();
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoreProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void CriarTabelas(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoreProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
//DDL - Data Definition Language - Linguagem de Definição de Dados.
//São os comandos que interagem com os objetos do banco.

//São comandos DDL : CREATE, ALTER e DROP  

//SELECT COUNT(name) AS qtde FROM sys.databases WHERE name = 'cfsrestaurante'