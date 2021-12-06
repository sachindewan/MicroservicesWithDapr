using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Events
{
    public class OrderRegisteredEvent
    {
        public Guid OrderId { get; set; }
        public string UserEmail { get; set; }
        public byte[] ImageData { get; set; }
    }
}
