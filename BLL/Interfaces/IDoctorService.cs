using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace BLL.Interfaces
{
    public interface IDoctorService
    {
        public Task AddDoctor(Doctor doctor);

        public Task<ICollection<Doctor>> GetAllDoctors();

        public Task<Doctor> GetDoctorById(int doctorId);

        public Task<ICollection<Doctor>> GetDoctorByFilter(Expression<Func<Doctor, bool>> expression);

        public Task<Doctor> DeleteDoctor(int doctorId);
        public Task UpdateDoctor(Doctor doctor);
    }
}
