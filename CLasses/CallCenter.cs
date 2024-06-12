using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Assignment6._3.CLasses;

namespace Assignment6._3
{
    internal class CallCenter
    {
        private int counter = 0;

        public Queue<IncomingCall> CallQueue { get; set; }

        public CallCenter()
        {
            CallQueue = new Queue<IncomingCall>();
        }

        public IncomingCall Call(int Id)
        {
            if (CallQueue.Count > 0)
            {
                return null;
            }
            
            IncomingCall call = new()
            {
                CallId = ++counter
            };
            CallQueue.Enqueue(call);
            Console.WriteLine();
            Console.WriteLine("Call {0} has been assigned to the queue.", call.CallId);
            return call;
        }

        public void Answer()
        {
            
            CallQueue.Dequeue();
            counter--;
            Console.WriteLine();
            Console.WriteLine("The call has been removed from the queue.");
            DisplayCallCount();
        }

        public int GetCallCount()
        {
            return counter;
        }

        public void DisplayCallCount()
        {
            Console.WriteLine();
            Console.WriteLine("There are {0} calls in the queue.", counter);
        }

        public void DisplayCallIds()
        {
            foreach (var call in CallQueue)
            {
                Console.WriteLine("Call Id {0}", call.CallId);
            }
        }
    }
}
