using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // https://www.tutorialsteacher.com/csharp/csharp-event
    /*
     An event is a notification sent by an object to signal the occurrence of an action. Events in .NET follow the observer design pattern.
    The class who raises events is called Publisher, and the class who receives the notification is called Subscriber. There can be multiple subscribers of a single event. Typically, a publisher raises an event when some action occurred. The subscribers, who are interested in getting a notification when an action occurred, should register with an event and handle it.
    In C#, an event is an encapsulated delegate. It is dependent on the delegate. The delegate defines the signature for the event handler method of the subscriber class.
      
     */
    public class Program
    {
        static void Main(string[] args)
        {

            // An example declaring an delegate and an event, the "old school" way
            Consumer cons1 = new Consumer();

            // an exemple using the built in "EventHandler" that comes with the .Net framework
            ConsumerEventHandler cons2 = new ConsumerEventHandler();

            // Using the built in "Event Handler" and returning some custom data
            ConsumerEventHandlerWithData cons3 = new ConsumerEventHandlerWithData();

            cons1.Execute();

            cons2.Execute();

            cons3.Execute();
        }
    }
}
