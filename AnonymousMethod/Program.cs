using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    //As the name suggests, an anonymous method is a method without a name. 
    public class Program
    {
        public delegate void Print(int value);
        public static void Main(string[] args)
        {
            Test1();

            Test2();

            Test3();

            Test4();
        }

      
        private static void Test1()
        {
            //Anonymous methods in C# can be defined using the delegate keyword and can be assigned to a variable of delegate type
            Print print = delegate (int val)
            {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);
        }

        private static void Test2()
        {
            // Anonymous methods can access variables defined in outside the anonymous method.
            int i = 10;

            Print prnt = delegate (int val)
            {
                val += i;
                Console.WriteLine("Anonymous method: {0}", val);
            };

            prnt(100);
        }

        private static void Test3()
        {
            // Anonymous methods can also be passed to a method that accepts the delegate as a parameter.
            // In the following example, PrintHelperMethod() takes the first parameters of the Print delegate:
            PrintHelperMethod(delegate (int val) { Console.WriteLine("Anonymous method: {0}", val); }, 100);
        }
        public static void PrintHelperMethod(Print printDel, int val)
        {
            val += 10;
            printDel(val);
        }

        private static void Test4()
        {
            Processor p = new Processor();

            p.Saved += delegate (Object o, EventArgs e)
            {
                Console.WriteLine("Save Successfully on the Processor!");
            };
        }


    }
}
