using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    class Orders
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
    }
}
