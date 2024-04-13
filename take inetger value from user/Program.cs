using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace take_inetger_value_from_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt message to take input
            Console.Write("Enter  an integer value: ");
            
            // it will first read the inner code that is C.RL --->than convert it to integer
            //------> tha store it to variable integer  num

            int num = Convert.ToInt32(Console.ReadLine());

                    // print the value

            Console.WriteLine("Integer value is  = " + num);
            Console.WriteLine("And the datatype value is :" +num.GetType());
            Console.ReadLine();
        }
    }
}
