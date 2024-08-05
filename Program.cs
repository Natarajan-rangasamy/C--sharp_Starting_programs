using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console.Write("Enter the number you wanna check: ");
              int a = Convert.ToInt32(Console.ReadLine());
              if (a % 2 == 0)
              {
                  Console.WriteLine("It's an Even");
              }
              else
              {
                  Console.WriteLine("It's an Odd");
              }
              // conditional operator
              Console.Write("Enter the age : ");
              int age = 0;
               age = Convert.ToInt32(Console.ReadLine());
              string res = (age >= 0) ? "valid" : "Invalid";
              Console.WriteLine(res);*/
            //Number foramatting
            var value = 586156.459;
            Console.WriteLine(string.Format("{0} {1} this is {2}",value,526,154));
            Console.WriteLine(string.Format("{0:0.0} {1:0.00}",value,519.12026));  //for how many decimals to be printed awesome one # symbol after the point will cut off the trailing zeros
            //Exception handling
          //  int num = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine(num); //Throws exception if I enter mismatched type
            //to rectify we can use tryParse
            string value1 = Console.ReadLine();
            int num1 = 0;
            int.TryParse(value1, out num1);
            Console.WriteLine(num1);
            //here is something awesome
            string name = "Natarajan software developer!";
            Console.Write("Do you know who he was? ");
            Thread.Sleep(2000);
            for (int i = 0; i < name.Length; i++) {
                Console.Write(name[i]);
                Thread.Sleep(200);
            }
            Console.WriteLine();

        }
    }
}
