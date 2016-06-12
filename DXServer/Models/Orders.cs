using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXServer.Models
{
    public enum OrderStatus
    {
        Placed = 0,
        Preparing = 1,
        Delivering = 2,
        Finished = 3
    }
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime Stamp { get; set; }
        public OrderStatus Status { get; set; }
        public int Cinema { get; set; }
        public int Row { get; set; }
        public int Chair { get; set; }

        public List<OrderItem> Items {get;set;}

    }
}
