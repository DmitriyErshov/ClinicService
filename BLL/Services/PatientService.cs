using BLL.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.RepositoryIntrefaces;

namespace BLL.Services
{
    public class PatientService : IPatientService
    {
        private IRepository<Patient> _repository;

        public PatientService(IRepository<Patient> repository)
        {
            _repository = repository;
        }

        public Task AddPatient(Patient patient)
        {
            return _repository.CreateAsync(patient);
        }

        public Task<Patient> DeletePatient(int patientId)
        {
            return _repository.DeleteItemAsync(patientId);
        }

        public Task<ICollection<Patient>> GetAllPatients()
        {
            return _repository.GetAllAsync();
        }

        public Task<ICollection<Patient>> GetlPatientByFilter(Expression<Func<Patient, bool>> expression)
        {
            return _repository.GetByFilterAsync(expression);
        }


        public Task<Patient> GetlPatientById(int patientId)
        {
            return _repository.GetByIdAsync(patientId);
        }

        public Task Patient(Patient patient)
        {
            return _repository.CreateAsync(patient);
        }

        public Task UpdatePatient(Patient patient)
        {
            return _repository.UpdateItemAsync(patient);
        }
    }
}
