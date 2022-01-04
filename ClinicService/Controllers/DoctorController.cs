using BLL.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicService.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorService _service;


        public DoctorController(IDoctorService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateNewDoctor()
        {
            List<Specialization> ListDepartments = new List<Specialization>()
            {
                new Specialization() {Id = 1, Name="Терапевт" },
                new Specialization() {Id = 2, Name="Стоматолог" },
                new Specialization() {Id = 3, Name="Кардиолог" },
            };
            ViewBag.Specializations = new SelectList(ListDepartments, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDoctor([FromForm] Doctor doctor)
        {

            await _service.Doctor(doctor);
            return Redirect("/Home/Index");
        }
    }
}
