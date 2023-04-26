using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern.Core
{
    internal class Order
    {
        private List<OrderLine> _lines = new();
        public IEnumerable<OrderLine> Lines => _lines.AsReadOnly();

        public void AddLine(int itemId, double quantity, decimal unitPrice)
        {
            _lines.Add(new OrderLine
            {
                ItemId = itemId,
                Quantity = quantity,
                unitPrice = unitPrice
            });
        }
    }
}
