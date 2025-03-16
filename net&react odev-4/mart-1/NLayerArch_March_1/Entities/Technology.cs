using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Technology : BaseEntity<int>
    {
        public string Name { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}
