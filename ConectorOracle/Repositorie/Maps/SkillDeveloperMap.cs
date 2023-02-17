using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectorOracle.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConectorOracle.Repositorie.Maps
{
    public class SkillDeveloperMap : BaseDomainMap<SkillDeveloper>
    {
        public SkillDeveloperMap() : base("tbl_skill_developer"){ }

        public override void Configure(EntityTypeBuilder<SkillDeveloper> builder)
        {
            base.Configure(builder);
            builder.Property(e => e.Cod).HasColumnName("cod").IsRequired();
            builder.Property(e => e.DeveloperId).HasColumnName("DeveloperId").IsRequired();
            builder.Property(e => e.SkillId).HasColumnName("skillId").IsRequired();
        }
    }
}
