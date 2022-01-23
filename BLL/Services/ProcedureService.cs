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
    public class ProcedureService : IProcedureService
    {
        private IRepository<Procedure> _repository;
        public ProcedureService(IRepository<Procedure> repository)
        {
            _repository = repository;
        }
        public Task AddProcedure(Procedure procedure)
        {
            return _repository.CreateAsync(procedure);
        }

        public Task<Procedure> DeleteProcedure(int procedureId)
        {
            return _repository.DeleteItemAsync(procedureId);
        }

        public Task<ICollection<Procedure>> GetAllProcedures()
        {
            return _repository.GetAllAsync();
        }

        public Task<ICollection<Procedure>> GetlProcedureByFilter(Expression<Func<Procedure, bool>> expression)
        {
            return _repository.GetByFilterAsync(expression);
        }

        public Task<Procedure> GetlProcedureById(int procedureId)
        {
            return _repository.GetByIdAsync(procedureId);
        }

        public Task UpdateProcedure(Procedure procedure)
        {
            return _repository.UpdateItemAsync(procedure);
        }
    }
}
