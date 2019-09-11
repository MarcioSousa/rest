using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Control
{
    public class DQL
    {
        private readonly SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
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
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
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

                sqlConnection.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
//DQL - Data Query Language - Linguagem de Consulta de dados.
//São os comandos de consulta.

//São comandos DQL : SELECT(é o comando de consulta)