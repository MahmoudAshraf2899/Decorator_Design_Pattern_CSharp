using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern.Core
{
    internal interface IOrderProcessor
    {
        void process(Order order);
    }
}
