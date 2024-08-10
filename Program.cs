using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Console.Title = "Concepts of C#";
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
            /* var value = 586156.459;
             Console.WriteLine(string.Format("{0} {1} this is {2}",value,526,154));
             Console.WriteLine(string.Format("{0:0.0} {1:0.00}",value,519.12026));*/
            //for how many decimals to be printed awesome one # symbol after the point will cut off the trailing zeros
            //Exception handling
            //  int num = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(num); //Throws exception if I enter mismatched type
            //to rectify we can use tryParse
            // string value1 = Console.ReadLine();
            //  int num1 = 0;
            // int.TryParse(value1, out num1);
            // Console.WriteLine(num1);
            //here is something awesome
            // string name = "Natarajan software developer!";
            // Console.Write("Do you know who he was? ");
            //Thread.Sleep(2000);
            // for (int i = 0; i < name.Length; i++) {
            /*     Console.Write(name[i]);
                 Thread.Sleep(200);
             }
             Console.WriteLine();*/
            //Arrays
            /* int[] exampleArray = new int[5];
             for (int i = 0; i < exampleArray.Length; i++) { 
                 exampleArray[i] = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Next uh...");
             }
             for (int i = 0; i < exampleArray.Length; i++) { 
                 Console.Write(exampleArray[i]+" ");
             }
             Console.WriteLine();
             foreach(int num in exampleArray) { 
                 Console.WriteLine(num);
             }
             */
            //Array Sorting
            int[] newarr = { 1, 2, 3, 4, 5, 6 };
            Array.Sort(newarr);
            //Toreverse an Array
            // Array.Reverse(newarr);
            //Array.clear will accept 3 arguments 1st one will be arrayname,2nd argument will be starting index 3rd will no of values to be cleared from that index
            /*  Array.Clear(newarr,5,1);
              for (int i = 0; i < newarr.Length; i++) {Console.WriteLine(newarr[i]); }
              */
            //to find the position of a number or an any item in a array use IndexOf method
            //Console.WriteLine(Array.IndexOf(newarr, 6)); 
            //the last 2 arguements are range from 3rd index upto 2 position;
            //Array.IndexOf(newarr, 1,3,2);
            //List in C#
            /*List<int> myList = new List<int>();
            for (int i = 0; i <= 7; i++) { 
                myList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Thread.Sleep(1000);
            Console.WriteLine("Here..");
            for (int i = 0; i < myList.Count; i++) { 
                Thread.Sleep(300);
                Console.WriteLine(myList[i]);
            }*/
            //Dictionary
            //It is a generic collection of Key value pairs
            /* Dictionary<int,string> emp = new Dictionary<int,string>();
             emp.Add(258, "venki");
             emp.Add(567, "Sam");
             emp.Add(789, "anderson");
             emp.Add(757, "Jackie");
             emp[259] = "junki";
             for (int i = 0; i < emp.Count; i++)
             {
                 KeyValuePair<int,string> kv = emp.ElementAt(i);
                 Console.WriteLine(kv.Key+" - "+kv.Value);
                // Console.WriteLine(kv);
             }*/

            //so important one I think
            //functions
            //Printing numbers
           // printNumbers(5);
            Outside obj = new Outside();
            //to acces the method in outer class directly it should be static 
            //or else if it not we create an instance like this 
            //  obj.accessing(10);
            Console.WriteLine("Name the console");
            /* string name = Console.ReadLine();
             if (name != null)
             {
                 Console.Title = name;
             }
            */
            //like parseInt int in java here we have int.TryParse(string , out num);
            //same for other data types alse
            // printNumbers(10);
            /* string name = "";
             name = name.Trim();
             bool chk = name.Equals(string.Empty);
             Console.WriteLine(chk);
             Console.WriteLine(name);*/
            //out and ref so important topics pending look at this 
            // The major differance 3 differance between out and ref functions are 
            //1 -> ref is bi directional but out is unidirectional
            //for example
            /*int num=7;
             Console.WriteLine(num);
             outexample(out num);
             Console.WriteLine(num);*/

            // here in the out parameter we need not to initialize
            //but in the funtion we are processing the out variable there it should be assigned some value
            // but in ref parameter we have to initialize the variable both before and after passing
            //for the example 
            string myname = "Harish";
            refExample(ref myname);
            Console.WriteLine(myname);

            //Try Catch Exception
            /*Console.WriteLine("Enter some numbers");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number accepted....|:)");
            }
            catch (Exception e) {
                Console.WriteLine($"Enter the specified Inputs only \n and The Error is {e.Message}");
            }*/
            

        }

        private static void refExample(ref string myname)
        {
            Console.WriteLine(myname);
            myname = "Changed -> Natarajan Rangasamy";
        }

        private static void outexample(out int num)
        {
          //  Console.WriteLine(num);//read the error i.e the variable is unassigned 
            num = 21;
        }

        private static void printNumbers(int v)
        {
            Console.WriteLine("Printing........... something");
            float.TryParse("58.9", out float value);
            Console.WriteLine(value);
        }
    }
    class Outside
    {
        public  void accessing(int i)
        {
            
            Console.WriteLine("You are accessing from outside the class");
        }
    }
}
