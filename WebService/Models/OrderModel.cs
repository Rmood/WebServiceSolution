﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
    }
}
