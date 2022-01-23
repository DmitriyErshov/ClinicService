using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Domain.Entities;

namespace ClinicService.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreatePatient()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePatient([FromForm] Patient patient)
        {
            await _patientService.Patient(patient);
            return Redirect("/Home/Index");
        }

        [HttpGet]
        public IActionResult GetAllPatients()
        {
            var patients = _patientService.GetAllPatients().Result;
            return View(patients);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Patient patient = await _patientService.GetlPatientById((int)id);
                if (patient != null)
                    return View(patient);
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> UpdatePatient(int? id)
        {
            if (id != null)
            {
                Patient patient = await _patientService.GetlPatientById((int)id);
                if (patient != null)
                    return View(patient);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePatient(Patient patient)
        {
            await _patientService.UpdatePatient(patient);
            return Redirect("/Home/Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Patient patient = await _patientService.GetlPatientById((int)id);
                if (patient != null)
                    return View(patient);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Patient patient = await _patientService.GetlPatientById((int)id);
                if (patient != null)
                {
                    await _patientService.DeletePatient((int)id);
                    return Redirect("/Home/Index");
                }
            }
            return NotFound();
        }
    }
}
