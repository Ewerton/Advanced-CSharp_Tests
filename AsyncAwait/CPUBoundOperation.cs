using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitLib
{
    public class CPUBoundOperation
    {

        public async Task<int> ExpensiveCalculation()
        {
            // For CPU bound operations is desired to execute those operations in a separate thread (in I/O bound you should never do it)
            // So, we use Task.Run() to execute it in another thread and this method become just an "entry point" for the Expensive Calculation itself which will be done by ExpensiveCalculationInAnotherThread()
            var resultOfExpensiveCalc = await Task.Run(() => ExpensiveCalculationInAnotherThread());
            return resultOfExpensiveCalc;
        }

        private int ExpensiveCalculationInAnotherThread()
        {
            // Simulates some expensive calculation
            Thread.Sleep(3000);

            Random rand = new Random(1000);
            var res = rand.Next();

            return res;
        }

    }
}
