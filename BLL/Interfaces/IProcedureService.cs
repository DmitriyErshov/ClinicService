using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace BLL.Interfaces
{
    public interface IProcedureService
    {
        public Task AddProcedure(Procedure procedure);

        public Task<ICollection<Procedure>> GetAllProcedures();

        public Task<Procedure> GetlProcedureById(int procedureId);

        public Task<ICollection<Procedure>> GetlProcedureByFilter(Expression<Func<Procedure, bool>> expression);

        public Task<Procedure> DeleteProcedure(int procedureId);
        public Task UpdateProcedure(Procedure procedure);
    }
}
