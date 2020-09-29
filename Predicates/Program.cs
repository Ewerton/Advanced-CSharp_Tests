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
        }

        static bool IsUpperCaseMethod(string str)
        {
            return str.Equals(str.Trim().ToUpper());
        }
    }
}
