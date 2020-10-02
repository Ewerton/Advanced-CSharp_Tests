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
            ConsumerWithoutParams cons1 = new ConsumerWithoutParams();

            // An example declaring an delegate and an event, the "old school" way but using the default params in the .Net way
            ConsumerWithDefaultParameters cons2 = new ConsumerWithDefaultParameters();

            // an exemple using the built in "EventHandler" that comes with the .Net framework
            ConsumerWithBuiltInEventHandler cons3 = new ConsumerWithBuiltInEventHandler();

            // Using the built in "Event Handler" and returning some custom data
            ConsumerEventHandlerWithCustomParams cons4 = new ConsumerEventHandlerWithCustomParams();

            cons1.Execute();

            cons2.Execute();

            cons3.Execute();

            cons4.Execute();
        }
    }
}
