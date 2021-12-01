using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class DoctorRepository : Repository<Doctor>
    {
        public DoctorRepository(ClinicContext context) : base(context)
        {

        }

        public override async Task<ICollection<Doctor>> GetAllAsync()
        {
            return await Context.Doctors.Include(e => e.Specialization).ToListAsync();
        }

        public override async Task<ICollection<Doctor>> GetByFilterAsync(Expression<Func<Doctor, bool>> expression)
        {
            return await Context.Doctors.Where(expression).Include(e => e.Specialization).ToListAsync();
        }

        public override async Task<Doctor> GetByIdAsync(int id)
        {
            return await Context.Doctors.Include(e => e.Specialization).FirstOrDefaultAsync(e => e.Id == id);
        }
        
    }
}
