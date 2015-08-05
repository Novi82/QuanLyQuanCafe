using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace QLQuanCafe.DAO
{
    /// <summary>
    /// MySqlDataProvider help connect and work with MySql Server.
    /// </summary>
    public class MySqlDataProvider
    {
        private MySqlConnection _sqlConnection = new MySqlConnection();

        /// <summary>
        /// Init connection.
        /// </summary>
        public MySqlDataProvider()
        {
            try
            {
                _sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectString"].ConnectionString;
                _sqlConnection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Close connection.
        /// </summary>
        public void Close()
        {
            _sqlConnection.Close();
            _sqlConnection.Dispose();
        }

        /// <summary>
        /// Get data by stored procedure.
        /// </summary>
        /// <param name="sqlStoredProcedureName">Stored Procedure Name</param>
        /// <returns>DataTable</returns>
        public DataTable ExecuteReader(string sqlStoredProcedureName)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(sqlStoredProcedureName, _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Get data by stored procedure with parameters.
        /// </summary>
        /// <param name="sqlStoredProcedureName">Stored Procedure Name</param>
        /// <param name="sqlStoredProcedureParams">parameters</param>
        /// <returns>DataTable</returns>
        public DataTable ExecuteReader(string sqlStoredProcedureName, Dictionary<string, object> sqlStoredProcedureParams)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(sqlStoredProcedureName, _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                foreach (var param in sqlStoredProcedureParams)
                {
                    string paramName = param.Key;
                    object paramValue = param.Value;

                    command.Parameters.AddWithValue(paramName, paramValue);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Insert, Update, Delete by stored procedure.
        /// </summary>
        /// <param name="sqlStoredProcedureName"></param>
        /// <returns>return 1 if succeed, 0 if fail</returns>
        public int ExecuteNonQuery(string sqlStoredProcedureName)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(sqlStoredProcedureName, _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                return command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Insert, Update, Delete by stored procedure with parameters.
        /// </summary>
        /// <param name="sqlStoredProcedureName">Stored Procedure Name</param>
        /// <param name="sqlStoredProcedureParams">parameters</param>
        /// <returns>return 1 if succeed, 0 if fail</returns>
        public int ExecuteNonQuery(string sqlStoredProcedureName, Dictionary<string, object> sqlStoredProcedureParams)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(sqlStoredProcedureName, _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                foreach (var param in sqlStoredProcedureParams)
                {
                    string paramName = param.Key;
                    object paramValue = param.Value;

                    command.Parameters.AddWithValue(paramName, paramValue);
                }


                return command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
    }
}
