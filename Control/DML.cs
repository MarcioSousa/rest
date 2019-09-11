using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Control
{
    public class DML
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
        public object ExecutarManipulacao(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            try
            {
                int codigo;

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

                codigo = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlConnection.Close();

                return codigo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
//DML - Data Manipulation Language - Linguagem de Manipulação de Dados.
//São os comandos que interagem com os dados dentro das tabelas.

//São comandos DML : INSERT, DELETE e UPDATE