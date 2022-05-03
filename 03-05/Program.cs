using System;
using System.Data.SqlClient;

namespace _03_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnetionString = "Data Source=DESKTOP-25SHDUN\\SQLEXPRESS;Initial Catalog=c#;Integrated Security=true;";
           SqlConnection sqlConnection = new SqlConnection(ConnetionString);
            sqlConnection.Open();

        }
    }
}
