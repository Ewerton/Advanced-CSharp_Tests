using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicates
{
    class Program
    {
        // Remember: Predicate delegate takes one input parameter and boolean return type.
        static void Main(string[] args)
        {
            Predicate<string> isUpperPredicate = IsUpperCaseMethod;

            bool result = isUpperPredicate("hello world!!");

            Console.WriteLine(result);

            // It also can be an anonymous method
            //Predicate<string> isUpper = delegate (string s) { return s.Equals(s.ToUpper()); };
            //bool result = isUpper("hello world!!");

            // Or lambda
            //Predicate<string> isUpper = s => s.Equals(s.ToUpper());
            // bool result = isUpper("hello world!!");

            TestMyOwnWhere();


        }


        static bool IsUpperCaseMethod(string str)
        {
            return str.Equals(str.Trim().ToUpper());
        }
        private static void TestMyOwnWhere()
        {
            List<string> fruits = new List<string> { "apple", "passionfruit", "banana", "mango", "orange", "blueberry", "grape", "strawberry" };

            // Calling my own where function to test how Func and predicates works as method parameters 
            IEnumerable<string> query = fruits.MyOwnWhere(fruit => fruit.Length <= 6);

            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }
        }

    }
}
