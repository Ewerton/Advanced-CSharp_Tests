using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class ConsumerWithDefaultParameters
    {
        public void Execute()
        {
            PublisherWithDefaultParameters pub = new PublisherWithDefaultParameters();

            // This class is the consumer of the publisher, so we want to subscribe to the ProcessCompleted event to be notified when it ends.
            pub.ProcessCompleted += OnProcessCompleted;   
            pub.StartProcess();
        }

        // event handler
        private void OnProcessCompleted(object source, EventArgs args)
        {
            Console.WriteLine("Process Completed on Consumer!");
        }
    }
}
