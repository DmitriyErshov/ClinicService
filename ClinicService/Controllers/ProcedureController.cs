using BLL.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ClinicService.Controllers
{
    public class ProcedureController : Controller
    {
        private readonly IProcedureService _procedureService;
        public ProcedureController(IProcedureService procedureService)
        {
            _procedureService = procedureService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateProcedure()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProcedure([FromForm] Procedure procedure)
        {
            await _procedureService.AddProcedure(procedure);
            return Redirect("/Procedure/GetAllProcedures");
        }

        [HttpGet]
        public IActionResult GetAllProcedures()
        {
            var procedures = _procedureService.GetAllProcedures().Result;
            return View(procedures);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Procedure procedure = await _procedureService.GetlProcedureById((int)id);
                if (procedure != null)
                    return View(procedure);
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id != null)
            {
                Procedure procedure = await _procedureService.GetlProcedureById((int)id);
                if (procedure != null)
                    return View(procedure);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Update(Procedure procedure)
        {
            await _procedureService.UpdateProcedure(procedure);
            return Redirect("/Procedure/GetAllProcedures");
        }


        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Procedure procedure = await _procedureService.GetlProcedureById((int)id);
                if (procedure != null)
                    return View(procedure);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Procedure procedure = await _procedureService.GetlProcedureById((int)id);
                if (procedure != null)
                {
                    await _procedureService.DeleteProcedure((int)id);
                    return Redirect("/Procedure/GetAllProcedures");
                }
            }
            return NotFound();
        }
    }
}
