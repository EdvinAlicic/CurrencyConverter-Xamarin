﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RMAProjekat.Tables
{
    class RegUserTable
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
    }
}
