﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class PublisherWithEventHandlerWithCustomParams
    {
        // public delegate void Notify();  // delegate
        // public event Notify ProcessCompleted; 

        // declaring an event using built-in EventHandler .net offer, no need to declare a "delegate" and a "event"
        public event EventHandler<ProcessingResult> ProcessCompleted;

        // Or using a class derived from EventArgs
        // public event EventHandler<ProcessingArgs> ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            Thread.Sleep(3000);
            var result = new ProcessingResult() { Success = true, FinishDate = DateTime.Now };
            OnProcessCompleted(result); //No event data
        }

        //Protected and virtual enable derived classes to override the logic for raising the event. 
        //However, A derived class should always call the On<EventName> method of the base class to ensure that registered delegates receive the event.
        protected virtual void OnProcessCompleted(ProcessingResult e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
}
