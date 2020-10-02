using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class PublisherWithDerivedReturn
    {
        // 1 -  Declare a Delegate
        public delegate void ProcessCompletedEventHandler(object source, ProcessingArgs args); // delegate 
        
        // 2 - Define an event based on that delegate
        public event ProcessCompletedEventHandler ProcessCompleted; // event which return a delegate type

        // 3 - Raise the event when apropriate

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            Thread.Sleep(3000);
            OnProcessCompleted(true, DateTime.Now);
        }

        //Protected and virtual enable derived classes to override the logic for raising the event. 
        //However, A derived class should always call the On<EventName> method of the base class to ensure that registered delegates receive the event.
        protected virtual void OnProcessCompleted(bool success, DateTime dateFinished)
        {
            // 3 - Raising the event
            if (ProcessCompleted != null) // If someone is subscribed to the event...
            {
                ProcessingArgs procArgs = new ProcessingArgs();
                procArgs.Success = success;
                procArgs.FinishDate = dateFinished;

                ProcessCompleted(this, procArgs); //  Notify the subscribers that the Process is Completed
            }
        }
    }
}
