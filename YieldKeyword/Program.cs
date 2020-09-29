using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldKeyword
{
    //https://pt.stackoverflow.com/questions/44293/qual-a-utilidade-da-palavra-reservada-yield

    /* Quando usar?
    Ele é muito utilizado para postergar a execução de um código. 
    Isto permite melhorar a performance em vários cenários porque ao invés de executar todo um loop para iterar em uma sequência de dados ele vai passo a passo até onde precisa. 
    E encerra definitivamente se quem chama um método achou o que precisava sem passar por todos valores. 
    Em alguns casos toda iteração pode ser evitada. Além disto a o tempo gasto para iterar fica para o momento da real utilização.

    */
    class Program
    {
        static void Main(string[] args)
        {
            Sample1();

            Sample2();

            Sample3();

            Sample4();

            Console.ReadKey();

        }

        private static void Sample1()
        {
            // Display powers of 2 up to the exponent of 8:
            foreach (int i in Power(2, 8))
            {
                Console.WriteLine("{0} ", i);
            }
        }

        private static void Sample2()
        {
            // The call to MyStringCreator doesn't execute the body of the method. Instead the call returns an IEnumerable<string> into the elements variable.
            IEnumerable<string> elements = MyStringListCreator("Hello my friend...");
            foreach (string element in elements)
            {
                Console.WriteLine("{0} ", element);
            }
        }



        public static IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;

                // You use a yield return statement to return each element one at a time.
                // So, the returning of the elements occurs during the loop in the Sample1() 
                yield return result;
            }
        }

        private static IEnumerable<string> MyStringListCreator(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                result = str[i].ToString();

                // Supose the str is "Hello". 
                // In the first interaction the "H" character will be returned in the IEnumerable and the "state" of teh current loop will be saved.
                // In the seconde calling of MyStringListCreator() the "e" character will be returned because the state was saved, and so on.
                // Its like the MyStringListCreator() returns a value without exiting the whole method.

                // podemos dizer, de outra forma, que o método com yield retorna um valor sem sair deste método.
                // Claro que ele sai, mas sai sabendo onde parou e sabe que tem voltar lá quando ele for invocado novamente então dá a impressão que ele nunca saiu.

                // Ele gera o que poderíamos chamar de coleção de dados virtual temporária que é materializada mais tarde quando os dados são necessários de fato.
                yield return result;
            }
        }

        private static void Sample3()
        {
            Stopwatch st = new Stopwatch();

            st.Start();
            // Even if we need to iterate over the first five elements, all the 1 million records will be loaded.
            foreach (var num in GetOneMillionRecordsWithoutYeld())
            {
                Console.WriteLine("{0} ", num);
                if (num == 5)
                    break;
            }
            st.Stop();
            Console.WriteLine("Without yield method took: {0} seconds.", st.Elapsed.Milliseconds);
            st.Reset();


            // Using the yield, just the neede elements will be evaluated, in our exemple the first five elements.
            st.Start();
            foreach (var num in GetOneMillionRecordsWithYeld())
            {
                Console.WriteLine("{0} ", num);
                if (num == 5)
                    break;
            }
            st.Stop();
            Console.WriteLine("With yield method took: {0} seconds.", st.Elapsed.Milliseconds);
        }


        private static void Sample4()
        {
            List<string> lst1 = new List<string>() { "Hello", "World", "How" };
            List<string> lst2 = new List<string>() { "Are", "You", "?" };
            var merged = EfficientMerge<string>(lst1, lst2);

            foreach (var item in merged)
            {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<int> GetOneMillionRecordsWithoutYeld()
        {
            List<int> lst = new List<int>();
            for (int i = 1; i < 1000000; i++)
            {
                lst.Add(i);
            }

            return lst;
        }

        private static IEnumerable<int> GetOneMillionRecordsWithYeld()
        {
            for (int i = 1; i < 1000000; i++)
            {
                yield return i;
            }
        }

        public static IEnumerable<T> EfficientMerge<T>(List<T> list1, List<T> list2)
        {
            // If the yield creates kind of a "state machine" for a collection, we can implement a efficient "merge" operation to merge two lists

            foreach (var f in list1)
            {
                yield return f;
            }

            foreach (var s in list2)
            {
                yield return s;
            }
        }

    }

}
