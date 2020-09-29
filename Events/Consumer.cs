﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Consumer
    {
        public void Execute()
        {
            Publisher pub = new Publisher();

            // This class is the consumer of the publisher, so we want to subscribe to the ProcessCompleted event to be notified when it ends.
            pub.ProcessCompleted += WhenProcessCompleted;// register with an event
            pub.StartProcess();
        }

        // event handler
        public static void WhenProcessCompleted()
        {
            Console.WriteLine("Process Completed on Consumer!");
        }
    }
}
