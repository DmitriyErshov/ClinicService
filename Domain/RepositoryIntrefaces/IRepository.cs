using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryIntrefaces
{
    public interface IRepository <T>
    {
        Task<T> GetByIdAsync(int id);

        Task<T> DeleteItemAsync(int id);

        Task UpdateItemAsync(T item);

        Task<ICollection<T>> GetAllAsync();
        Task<ICollection<T>> GetByFilterAsync(Expression<Func<T, bool>> expression);

        Task CreateAsync(T item);
    }; 
}
