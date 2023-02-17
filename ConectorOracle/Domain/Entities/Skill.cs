using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectorOracle.Domain.Entities
{
    public class Skill : BaseDomain
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? SkillId { get; set; }

        public virtual List<Developer>? Developer { get; set; }

    }
}
