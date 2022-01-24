using BLL.Interfaces;
using DAL.Repositories;
using Domain.Entities;
using Domain.RepositoryIntrefaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AppointmentService : IAppointmentService
    {
        private IRepository<Appointment> _repository;
        private IRepository<AppointmentStatus> _repositoryStatus;
        public AppointmentService(IRepository<Appointment> repository, IRepository<AppointmentStatus> repositoryStatus)
        {
            _repository = repository;
            _repositoryStatus = repositoryStatus;
        }
        public Task AddAppointment(Appointment appointment)
        {
            return _repository.CreateAsync(appointment);
        }

        public Task<Appointment> DeleteAppointment(int appointmentId)
        {
            return _repository.DeleteItemAsync(appointmentId);
        }

        public Task<ICollection<Appointment>> GetAllAppointments()
        {
            return _repository.GetAllAsync();
        }

        public Task<ICollection<Appointment>> GetAppointmentByFilter(Expression<Func<Appointment, bool>> expression)
        {
            return _repository.GetByFilterAsync(expression);
        }

        public Task<Appointment> GetAppointmentById(int appointmentId)
        {
            return _repository.GetByIdAsync(appointmentId);
        }
        

        public Task UpdateAppointment(Appointment appointment)
        {
            return _repository.UpdateItemAsync(appointment);
        }

        public Task<AppointmentStatus> GetAppointmentStatusById(int appointmentStatusId)
        {
            return _repositoryStatus.GetByIdAsync(appointmentStatusId);
        }
    }
}
