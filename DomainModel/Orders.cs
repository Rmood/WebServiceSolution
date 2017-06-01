using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DomainModel
{
    public class Orders
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
    }
}
