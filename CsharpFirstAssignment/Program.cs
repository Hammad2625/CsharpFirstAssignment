using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFirstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Third Task**");

            Console.WriteLine("Please enter the value of A");
            int Value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value of B");
            int Value1 = Convert.ToInt32(Console.ReadLine());
            if (Value == Value1)
            {

                Console.WriteLine("Both intergers are Equal!");
            }
            else
            {

                Console.WriteLine("Both intergers are not Equal!");
            }
            Console.ReadLine();

            Console.WriteLine("**Second Task**");

            Console.WriteLine("Please enter the value of a");
            int Value3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value of b");
            int Value4 = Convert.ToInt32(Console.ReadLine());

            if ((Value3 < 0 && Value4 > 0) || (Value3 > 0 && Value4 < 0))
            {

                Console.WriteLine("True!");
            }
            else
            {
                Console.WriteLine("False");

            }

            Console.WriteLine("**First Task**");

            int a = 10;
            int b = 20;
            Console.WriteLine("This is the value of a before Swapping =" + a);
            Console.WriteLine("This is the value of b before Swapping =" + b);
            int c = a;
            a=b; b=c;
            Console.WriteLine("This is the value of a after Swapping =" + a);
            Console.WriteLine("This is the value of b after Swapping =" + b);




        }
    }
}
