using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day26
{
    internal class delete
    {
        static void Main(string[] args)
        {
            string cs = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=School;Integrated Security=True";
            SqlConnection con=new SqlConnection(cs);
            con.Open();
            string query = "delete from Student where ID=1";
            SqlCommand cmd=new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Deleted Sucessfully");
            con.Close();

        }
    }
}
