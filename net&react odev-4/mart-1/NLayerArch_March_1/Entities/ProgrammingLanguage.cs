﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities
{
    public class ProgrammingLanguage:BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
