using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAppointmentService
    {
        public Task AddAppointment(Appointment appointment);

        public Task<ICollection<Appointment>> GetAllAppointments();

        public Task<Appointment> GetAppointmentById(int appointmentId);

        public Task<ICollection<Appointment>> GetAppointmentByFilter(Expression<Func<Appointment, bool>> expression);

        public Task<Appointment> DeleteAppointment(int appointmentId);
        public Task UpdateAppointment(Appointment appointment);

        public Task<AppointmentStatus> GetAppointmentStatusById(int appointmentStatusId);

    }
}
