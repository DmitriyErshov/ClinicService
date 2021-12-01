using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Procedure : BaseEntity
    {
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
