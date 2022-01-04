using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DAL.Mappers
{
    class ProcedureConfiguration : IEntityTypeConfiguration<Procedure>
    {
        public void Configure(EntityTypeBuilder<Procedure> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(200);

            //сделать многие ко многим
            builder.HasMany(e => e.Appointments);
        }
    }
}
