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
    public class SpecializationService : ISpecializationService
    {
        private IRepository<Specialization> _repository;

        public SpecializationService(IRepository<Specialization> repository)
        {
            _repository = repository;
        }

        public Task Specialization(Specialization specialization)
        {
            return _repository.CreateAsync(specialization);
        }

        public Task AddSpecialization(Specialization specialization)
        {
            return _repository.CreateAsync(specialization);
        }

        public Task<ICollection<Specialization>> GetAllSpecializations()
        {
            return _repository.GetAllAsync();
        }

        public Task<Specialization> GetSpecializationById(int specializationId)
        {
            return _repository.GetByIdAsync(specializationId);
        }

        public Task<ICollection<Specialization>> GetSpecializationByFilter(Expression<Func<Specialization, bool>> expression)
        {
            return _repository.GetByFilterAsync(expression);
        }

        public Task<Specialization> DeleteSpecialization(int doctorId)
        {
            return _repository.DeleteItemAsync(doctorId);
        }

        public Task UpdateSpecialization(Specialization specialization)
        {
            return _repository.UpdateItemAsync(specialization);
        }
    }
}
