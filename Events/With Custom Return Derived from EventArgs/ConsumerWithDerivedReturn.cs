using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class ConsumerWithDerivedReturn
    {
        public void Execute()
        {
            PublisherWithDerivedReturn pub = new PublisherWithDerivedReturn();

            // This class is the consumer of the publisher, so we want to subscribe to the ProcessCompleted event to be notified when it ends.
            pub.ProcessCompleted += OnProcessCompleted;   
            pub.StartProcess();
        }

        // event handler
        private void OnProcessCompleted(object source, ProcessingArgs e)
        {
            Console.WriteLine(String.Format("Process Completed on Consumer at {0}!", e.FinishDate));
        }
    }
}
