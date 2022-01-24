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
    public class AppointmentRepository : Repository<Appointment>
    {
        public AppointmentRepository(ClinicContext context) : base(context)
        {

        }

        public override async Task<ICollection<Appointment>> GetAllAsync()
        {
            return await Context.Appointments
                .Include(e => e.Doctor).ThenInclude(e => e.Specialization)
                .Include(e => e.Patient)
                .Include(e => e.Status)
                .Include(e => e.Procedures).ToListAsync();
        }

        public override async Task<ICollection<Appointment>> GetByFilterAsync(Expression<Func<Appointment, bool>> expression)
        {
            return await Context.Appointments.Where(expression)
                .Include(e => e.Doctor).ThenInclude(e => e.Specialization)
                .Include(e => e.Patient)
                .Include(e => e.Status).ToListAsync();
        }

        public override async Task<Appointment> GetByIdAsync(int id)
        {
            return await Context.Appointments
                .Include(e => e.Doctor).ThenInclude(e => e.Specialization)
                .Include(e => e.Patient)
                .Include(e => e.Status)
                .Include(e => e.Procedures)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
