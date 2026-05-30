using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day26
{

    internal class menudriven
    {
        static string cs = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=School;Integrated Security=True";
        static void InsertStudent()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            string query =
                $"INSERT INTO Student VALUES({id},'{name}','{address}')";

            SqlCommand cmd =
                new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("Record Inserted");
        }
        static void DisplayStudents()
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM Student";

            SqlCommand cmd =
                new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr =
                cmd.ExecuteReader();

            Console.WriteLine("\nStudent Records");

            while (dr.Read())
            {
                Console.WriteLine(
                    dr["Id"] + "\t" +
                    dr["Name"] + "\t" +
                    dr["Address"]);
            }

            con.Close();
        }
        static void UpdateStudent()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Student Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("New Address: ");
            string address = Console.ReadLine();

            string query =
                $"UPDATE Student SET Address='{address}' WHERE Id={id}";

            SqlCommand cmd =
                new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("Record Updated");
        }
        static void DeleteStudent()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Student Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            string query =
                $"DELETE FROM Student WHERE Id={id}";

            SqlCommand cmd =
                new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("Record Deleted");
        }
        static void Main(string[] args)
        {   
                while (true)
                {
                    Console.WriteLine("\n1. Insert");
                    Console.WriteLine("2. Display");
                    Console.WriteLine("3. Update");
                    Console.WriteLine("4. Delete");
                    Console.WriteLine("5. Exit");

                    Console.Write("Choose Option: ");

                    int choice =
                        Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            InsertStudent();
                            break;

                        case 2:
                            DisplayStudents();
                            break;

                        case 3:
                            UpdateStudent();
                            break;

                        case 4:
                            DeleteStudent();
                            break;

                        case 5:
                            return;

                        default:
                            Console.WriteLine(
                                "Invalid Choice");
                            break;
                    }
                }
        }
    }
}
