using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProcedureRepository :  Repository<Procedure>
    {
        public ProcedureRepository(ClinicContext context) : base(context)
        {

        }

        public override async Task<ICollection<Procedure>> GetAllAsync()
        {
            return await Context.Procedures.Include(e => e.Appointments).ToListAsync();
        }

        public override async Task<ICollection<Procedure>> GetByFilterAsync(Expression<Func<Procedure, bool>> expression)
        {
            return await Context.Procedures.Where(expression).Include(e => e.Appointments).ToListAsync();
        }

        public override async Task<Procedure> GetByIdAsync(int id)
        {
            return await Context.Procedures.Include(e => e.Appointments).FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
