using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Appointment : BaseEntity
    {
        public Appointment()
        {
            Procedures = new List<Procedure>();
        }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }
        public AppointmentStatus Status { get; set; }
        public ICollection<Procedure> Procedures { get; set; }
    }
}
