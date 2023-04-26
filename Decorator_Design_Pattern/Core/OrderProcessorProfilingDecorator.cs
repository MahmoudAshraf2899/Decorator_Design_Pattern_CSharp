using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern.Core
{
    internal class OrderProcessorProfilingDecorator : IOrderProcessor
    {
        private readonly IOrderProcessor _orderProcessor;

        public OrderProcessorProfilingDecorator(IOrderProcessor orderProcessor)
        {
            _orderProcessor = orderProcessor;
        }
        public void process(Order order)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            _orderProcessor.process(order);
            stopWatch.Stop();
            Console.WriteLine($"Order Took `{stopWatch.Elapsed.TotalSeconds}` to be processed.");
        }
    }
}
