using BLL.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ClinicService.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorService _doctorService;
        private readonly ISpecializationService _specializationService;

        public DoctorController(IDoctorService doctorService, ISpecializationService specializationService)
        {
            _doctorService = doctorService;
            _specializationService = specializationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateDoctor()
        {
            ViewBag.Specializations = new SelectList(_specializationService.GetAllSpecializations().Result, "Id", "Name");
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDoctor([FromForm] Doctor doctor)
        {
            Specialization temp = await _specializationService.GetSpecializationById(doctor.Specialization.Id);
            doctor.Specialization = temp;

            await _doctorService.Doctor(doctor);
            return Redirect("/Home/Index");
        }

        [HttpGet]
        public IActionResult GetAllDoctors()
        {
            var doctors = _doctorService.GetAllDoctors().Result;
            return View(doctors);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Doctor doctor = await _doctorService.GetDoctorById((int)id);
                if (doctor != null)
                    return View(doctor);
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateDoctor(int? id)
        {
            if (id != null)
            {
                ViewBag.Specializations = new SelectList(_specializationService.GetAllSpecializations().Result, "Id", "Name");
                Doctor doctor = await _doctorService.GetDoctorById((int)id);
                if (doctor != null)
                    return View(doctor);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDoctor([FromForm] Doctor doctor)
        {
            Specialization temp = await _specializationService.GetSpecializationById(doctor.Specialization.Id);
            doctor.Specialization = temp;

            await _doctorService.UpdateDoctor(doctor);
            return Redirect("/Home/Index");
        }
    }
}
