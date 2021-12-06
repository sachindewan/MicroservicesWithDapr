﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Commands
{
    public class OrderStatusChangedToProcessedCommand
    {
        public Guid OrderId { get; set; }
        public List<byte[]> Faces { get; set; }
    }
}
