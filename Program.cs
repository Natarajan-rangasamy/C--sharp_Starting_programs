using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you wanna check: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("It's an Even");
            }
            else
            {
                Console.WriteLine("It's an Odd");
            }


            }
    }
}
