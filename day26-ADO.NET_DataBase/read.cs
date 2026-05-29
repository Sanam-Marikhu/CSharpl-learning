using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day26
{
    internal class read
    {
        static void Main(string[] args)
        {
            String cs="Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=School;Integrated Security=True";
            SqlConnection con=new SqlConnection(cs);
            con.Open();
            string query = "select * from Student";
            SqlCommand cd=new SqlCommand(query, con);
            SqlDataReader dr =
                cd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(
                    dr["Id"] + " " +
                    dr["Name"] + " " +
                    dr["Address"]);
            }

            con.Close();
        }
    }
}
