using Decorator_Design_Pattern.Core;
using System;

namespace Decorator_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            order.AddLine(1, 5, 1000);
            order.AddLine(2, 3, 2500);
            order.AddLine(3, 4, 1460);

            IOrderProcessor processor = new OrderProcessor();
            processor = new OrderProcessorProfilingDecorator(processor);
            processor.process(order);

            
            
            Console.ReadKey();
        }
    }
}
