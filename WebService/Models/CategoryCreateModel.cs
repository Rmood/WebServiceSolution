﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.Models
{
    public class CategoryCreateModel
    {
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}
