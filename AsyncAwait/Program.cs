using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitLib
{
    // Reference: https://docs.microsoft.com/en-us/dotnet/csharp/async

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Here are two questions you should ask before you write any code: Will your code be "waiting" for something, such as data from a database?
                If your answer is "yes", then your work is I/O - bound.
            Will your code be performing an expensive computation ?
                If you answered "yes", then your work is CPU - bound.
                        
            If the work you have is I/O - bound, use async and await WITHOUT Task.Run. You SHOULD NOT use the Task Parallel Library. 
            The reason for this is outlined in https://docs.microsoft.com/en-us/dotnet/standard/async-in-depth
            */

            SampleIOBoundOperation();

            SampleCPUBoundOperation();

            Console.ReadKey();
        }

        private async static void SampleIOBoundOperation()
        {
            IOBoundOperation ioBound = new IOBoundOperation();

            string word = "net";
            string url = "https://dotnetfoundation.org";
            
            var reqResult = await ioBound.GetWordCountInWebSite(url, word); //For C# 7.1
            //int qtd = ioBound.GetWordCountInWebSite(url, word).GetAwaiter().GetResult(); // Earlier versions of C#

            Console.WriteLine("The word \"{0}\" appears {1} times in the URL \"{2}\"", reqResult.Word, reqResult.Count, url);
        }

        private async static void SampleCPUBoundOperation()
        {
            CPUBoundOperation cpuBound = new CPUBoundOperation();

            int res = await cpuBound.ExpensiveCalculation(); //For C# 7.1
            //int qtd = cpuBound.ExpensiveCalculation().GetAwaiter().GetResult(); // Earlier versions of C#

            Console.WriteLine("The expensive calculation returned \"{0}\"", res);
        }
    }
}
