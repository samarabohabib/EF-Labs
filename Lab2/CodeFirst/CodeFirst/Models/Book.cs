﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Book
    {
        public int Id { get; set; }
        public String Title { get; set; }

        public List<Employee> employees { get; set; }

        public City City { get; set; }

        public Cover Cover { get; set; }

    }
}
