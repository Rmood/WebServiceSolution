﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DomainModel
{
    public class Clients
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Adress { get; set; }
    }
}
