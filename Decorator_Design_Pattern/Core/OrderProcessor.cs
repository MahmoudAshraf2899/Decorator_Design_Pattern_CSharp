using System;
using System.Threading;

namespace Decorator_Design_Pattern.Core
{
    internal class OrderProcessor : IOrderProcessor
    {
        public void process(Order order)
        {
            Console.WriteLine("Order Has been Processed");
        }
    }
}
