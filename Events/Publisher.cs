using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class Publisher
    {
        public delegate void Notify();  // delegate
        public event Notify ProcessCompleted; // event

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
            //if ProcessCompleted is not null then call delegate
            // If no one subscribe to this event, so it will be null. So, always check if it an event is null!
            ProcessCompleted?.Invoke();
        }
    }
}
