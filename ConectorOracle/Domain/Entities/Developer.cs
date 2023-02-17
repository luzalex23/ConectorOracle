using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectorOracle.Domain.Entities
{
    public class Developer : BaseDomain
    {
        public string? Nome { get; set; }
        public int? DeveloperId { get; set; }
        public int? Idade { get; set; }
        public string? Senioridade { get; set; }
        public List<Skill>? Skill { get; set; }
        public Developer() { }
        
    }
}
