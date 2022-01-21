using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace BLL.Interfaces
{
    public interface ISpecializationService
    {
        public Task Specialization(Specialization specialization);

        public Task AddSpecialization(Specialization specialization);

        public Task<ICollection<Specialization>> GetAllSpecializations();

        public Task<Specialization> GetSpecializationById(int specializationId);

        public Task<ICollection<Specialization>> GetSpecializationByFilter(Expression<Func<Specialization, bool>> expression);

        public Task<Specialization> DeleteSpecialization(int specializationId);
        public Task UpdateSpecialization(Specialization specialization);
    }
}
