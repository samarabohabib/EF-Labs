﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Cover
    { 
            public int Id { get; set; }
            public String Code { get; set; }

            public Book Book { get; set; }

    }
}
