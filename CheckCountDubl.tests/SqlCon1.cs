

using System.Configuration;
using System.Data.SqlClient;

namespace CheckCountDubl.Tests
{

    public class SqlCon1
    {

        private static string  connectionString = ConfigurationManager.ConnectionStrings["resultsDB"].ConnectionString;
        private static SqlConnection sqlConnect = null;
        public void insert(string str, int actual, int expected)
        {


            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();


            string res;
            if (actual != expected)
            {
                res = "Correct";
            }
            else
            {
                res = "NotCorrect";
            }


            string command = $"insert into Results (Id,Input,Output,Results) values (1,'{str}','{expected}','{res}')";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
        }
    }
}
