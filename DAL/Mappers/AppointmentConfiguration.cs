using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DAL.Mappers
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(c => c.Id);
            //builder.Property(c => c.Name).HasMaxLength(200);

            //сделать многие ко многим
            builder.HasMany(e => e.Procedures);
        }
    }
}