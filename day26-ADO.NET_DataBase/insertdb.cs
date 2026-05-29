using System;
using System.Data.SqlClient;

namespace day26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cs =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=School;Integrated Security=True";

            SqlConnection con =
                new SqlConnection(cs);

            con.Open();

            string query =
            "INSERT INTO Student VALUES " +
            "(3,'Shyam','Bhaktapur')," +
            "(4,'Sita','Kathmandu')," +
            "(5,'Gita','Lalitpur')";

           
            new SqlCommand(query, con).ExecuteNonQuery();

            Console.WriteLine(
                "Data Inserted Successfully");

            con.Close();
        }
    }
}