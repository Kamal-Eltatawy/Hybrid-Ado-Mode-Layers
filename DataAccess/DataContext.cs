using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class DataContext
    {
        SqlConnection connection;
        public DataContext()
        {
            connection = new SqlConnection("Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        //Disconnected Mode Select

        public DataTable GetData(string command)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand= new SqlCommand(command, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        // Connected NonQuery Select with 2 overloads
        public int NonQueryExcution(string command, SqlParameter[] sqlParameter) 
        {
             SqlCommand cmd = new SqlCommand(command, connection);
            cmd.Parameters.AddRange(sqlParameter);
            connection.Open();
            int affectedRow = cmd.ExecuteNonQuery();
            connection.Close();
            return affectedRow;
        }
        public int NonQueryExcution(string command, SqlParameter sqlParameter)
        {
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.Parameters.Add(sqlParameter);
            connection.Open();
            int affectedRow = cmd.ExecuteNonQuery();
            connection.Close();
            return affectedRow;
        }
    }
}