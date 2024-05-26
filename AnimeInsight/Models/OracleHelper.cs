using Microsoft.Extensions.Options;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace AnimeInsight.Models
{
    public class OracleHelper
    {
        private readonly string _connectionString;

        public OracleHelper(IOptions<ConnectionStringManager> connectionStringManager)
        {
            _connectionString = connectionStringManager.Value.DefaultConnection;
        }

        public string ExecuteHelloWorldFunction()
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                connection.Open();
                using (var command = new OracleCommand("GetHelloWorld", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Define the return parameter
                    var returnParameter = new OracleParameter("return_value", OracleDbType.Varchar2, 50)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(returnParameter);

                    // Execute the function
                    command.ExecuteNonQuery();

                    // Retrieve the result
                    return returnParameter.Value.ToString();
                }
            }
        }
    }
}
