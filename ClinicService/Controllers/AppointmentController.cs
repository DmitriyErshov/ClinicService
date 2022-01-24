using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClinicService.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IDoctorService _doctorService;
        private readonly IPatientService _patientService;
        private readonly IAppointmentService _appointmentService;
        private readonly IProcedureService _procedureService;


        public AppointmentController(IDoctorService doctorService, 
                                    IPatientService patientService,
                                    IAppointmentService appointmentService,
                                    IProcedureService procedureService)
        {
            _doctorService = doctorService;
            _patientService = patientService;
            _appointmentService = appointmentService;
            _procedureService = procedureService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> MakeAppointment(int? id)
        {
            ViewBag.Patients = new SelectList(_patientService.GetAllPatients().Result, "Id", "FirstName");

            if (id != null)
            {
                Doctor doctor = await _doctorService.GetDoctorById((int)id);
                if (doctor != null)
                {
                    Appointment appointment = new Appointment();
                    appointment.Doctor = doctor;
                    return View(appointment);
                }
                    
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> MakeAppointment([FromForm] Appointment appointment)
        {
            appointment.Doctor = await _doctorService.GetDoctorById(appointment.Doctor.Id);
            appointment.Patient = await _patientService.GetlPatientById(appointment.Patient.Id);
            appointment.Status = await _appointmentService.GetAppointmentStatusById(1);
            appointment.Procedures.Add(await _procedureService.GetlProcedureById(4));

            await _appointmentService.AddAppointment(appointment);
            return Redirect("/Home/Index");
        }

        [HttpGet]
        public IActionResult GetAllAppointment()
        {
            var appointment = _appointmentService.GetAllAppointments().Result;
            return View(appointment);
        }

        [HttpGet]
        public IActionResult GetDoctorAppointments(int? id)
        {
            var appointment = _appointmentService.GetAppointmentByFilter((Appointment x) => x.Doctor.Id == id).Result;
            return View("GetAllAppointment", appointment);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Appointment appointment = await _appointmentService.GetAppointmentById((int)id);
                if (appointment != null)
                    return View(appointment);
            }
            return NotFound();
        }
    }
}
