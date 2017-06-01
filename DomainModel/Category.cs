using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
}
}
