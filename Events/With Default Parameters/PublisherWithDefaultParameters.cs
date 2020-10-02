using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class PublisherWithDefaultParameters
    {
        // 1 -  Declare a Delegate
        public delegate void ProcessCompletedEventHandler(object source, EventArgs args); // delegate 
        
        // 2 - Define an event based on that delegate
        public event ProcessCompletedEventHandler ProcessCompleted; // event which return a delegate type

        // 3 - Raise the event when apropriate

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            Thread.Sleep(3000);
            OnProcessCompleted();
        }

        //Protected and virtual enable derived classes to override the logic for raising the event. 
        //However, A derived class should always call the On<EventName> method of the base class to ensure that registered delegates receive the event.
        protected virtual void OnProcessCompleted()
        {
            // 3 - Raising the event
            if (ProcessCompleted != null) // If someone is subscribed to the event...
                ProcessCompleted(this, EventArgs.Empty); //  Notify the subscribers that the Process is Completed
        }
    }
}
