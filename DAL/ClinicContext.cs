using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using DAL.Mappers;

namespace DAL
{
    public class ClinicContext : DbContext
    {
        //написать названия таблиц
        //dbset класс таблиц, отслеживает сущности
        public DbSet<Patient> Patients {get; set;}
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentStatus> AppointmentStatuses { get; set; }
        public DbSet<Procedure> Procedures { get; set; }

        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new ProcedureConfiguration());
            modelBuilder.ApplyConfiguration(new SpecializationConfiguration());
        }
    }
}
