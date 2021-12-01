using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public abstract class BasePerson : BaseEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }
        public string PassportNumber { get; set; }
    }

}
