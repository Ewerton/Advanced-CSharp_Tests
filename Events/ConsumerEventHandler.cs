﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class ConsumerEventHandler
    {
        public void Execute()
        {
            PublisherWithEventHandler pub = new PublisherWithEventHandler();

            // This class is the consumer of the publisher, so we want to subscribe to the ProcessCompleted event to be notified when it ends.
            pub.ProcessCompleted += WhenProcessCompleted;// register with an event
            pub.StartProcess();
        }

        // event handler
        public static void WhenProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed on ConsumerEventHandler!");
        }
    }
}
