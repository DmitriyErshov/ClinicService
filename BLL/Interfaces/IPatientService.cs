using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace BLL.Interfaces
{
    public interface IPatientService
    {
        public Task Patient(Patient patient);

        public Task AddPatient(Patient patient);

        public Task<ICollection<Patient>> GetAllPatients();

        public Task<Patient> GetlPatientById(int patientId);

        public Task<ICollection<Patient>> GetlPatientByFilter(Expression<Func<Patient, bool>> expression);

        public Task<Patient> DeletePatient(int patientId);
        public Task UpdatePatient(Patient patient);
    }
}
