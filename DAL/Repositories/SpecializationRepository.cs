using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class SpecializationRepository : Repository<Specialization>
    {
        public SpecializationRepository(ClinicContext context) : base(context)
        {

        }

        public override async Task<Specialization> GetByIdAsync(int id)
        {
            return await Context.Specializations.FirstOrDefaultAsync(e => e.Id == id);
        }

        public override async Task<ICollection<Specialization>> GetAllAsync()
        {
            return await Context.Specializations.ToListAsync();
        }
    }
}
