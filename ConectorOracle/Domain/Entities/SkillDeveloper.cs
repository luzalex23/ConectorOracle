using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectorOracle.Domain.Entities
{
    public class SkillDeveloper : BaseDomain
    {
        public int?  Cod { get; set; }
        public int? DeveloperId { get; set; }
        public int? SkillId { get; set; }

        public SkillDeveloper() { }
    }
}
