using BLL.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateDoctor([FromForm] Doctor doctor)
        //{

        //}
    }
}
