using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day26
{
    internal class update
    {
        static void Main(string[] args)
        {
            String cs = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=School;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "update Student set Address='Kathmandu' where Id=1";
            SqlCommand cd = new SqlCommand(query, con);
            cd.ExecuteNonQuery();
            Console.WriteLine("Updated Sucesfully");
            con.Close();
        }
    }
}
