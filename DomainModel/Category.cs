using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DomainModel
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
    }
}
