using BLL.Interfaces;
using Domain.Entities;
using Domain.RepositoryIntrefaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DoctorService : IDoctorService
    {
        private IRepository<Doctor> _repository;

        public DoctorService(IRepository<Doctor> repository)
        {
            _repository = repository;
        }

        public Task Doctor(Doctor doctor)
        {
            return _repository.CreateAsync(doctor);
        }

        public Task AddDoctor(Doctor doctor)
        {
            return _repository.CreateAsync(doctor);
        }

        public Task<ICollection<Doctor>> GetAllDoctors()
        {
            return _repository.GetAllAsync();
        }

        public Task<Doctor> GetDoctorById(int doctorId)
        {
            return _repository.GetByIdAsync(doctorId);
        }

        public Task<ICollection<Doctor>> GetDoctorByFilter(Expression<Func<Doctor, bool>> expression)
        {
            return _repository.GetByFilterAsync(expression);
        }

        public Task<Doctor> DeleteDoctor(int doctorId)
        {
            return _repository.DeleteItemAsync(doctorId);
        }

        public Task UpdateDoctor(Doctor doctor)
        {
            return _repository.UpdateItemAsync(doctor);
        }

        
    }
}
