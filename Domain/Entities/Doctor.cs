using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Doctor : BasePerson
    {
        public DateTime DateOfEntry { get; set; }
        public Specialization Specialization { get; set; }
    }
}
