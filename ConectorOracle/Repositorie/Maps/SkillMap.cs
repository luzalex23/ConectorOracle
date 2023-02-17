using ConectorOracle.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectorOracle.Repositorie.Maps
{
    public class SkillMap : BaseDomainMap<Skill>
    {
        public SkillMap() : base("tbl_skill") { }
        public override void Configure(EntityTypeBuilder<Skill> builder)
        {
            base.Configure(builder);
            builder.Property(e => e.SkillId).IsRequired();
            builder.Property(e => e.Description).IsRequired();
            builder.Property(e =>e.Name).IsRequired();
        }
    }
}
