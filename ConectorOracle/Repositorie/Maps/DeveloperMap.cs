using ConectorOracle.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectorOracle.Repositorie.Maps
{
    public class DeveloperMap : BaseDomainMap<Developer>
    {
        public DeveloperMap() : base ("tbl_developer"){ }

        public override void Configure(EntityTypeBuilder<Developer> builder)
        {
            base.Configure(builder);
            builder.Property(e => e.Nome).HasColumnName("Nome").HasMaxLength(10).IsRequired();
            builder.Property(e => e.DeveloperId).HasColumnName("DeveloperId").IsRequired();
            builder.Property(e => e.Idade).HasColumnName("Idade");
            builder.Property(e => e.Senioridade).HasColumnName("Senioridade");    
        }

    }

   
}
