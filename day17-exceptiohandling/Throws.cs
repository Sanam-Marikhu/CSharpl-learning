using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day17
{
    internal class Throws
    {
        static void Main(string[] args)
        {
            try 
            {

                Console.Write("Enter Your Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 0)
                {
                    throw new Exception("Age Cannot Be Negative");
                }
                Console.WriteLine("Age:"+age);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
          
            finally
            {
                Console.WriteLine("Program Ended");
            }
        }
          
    }
}
