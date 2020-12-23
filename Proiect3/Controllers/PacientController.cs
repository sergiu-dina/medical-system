using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proiect3.Models;
using Proiect3.Models.Services;
using Proiect3.ViewModel;

namespace Proiect3.Controllers
{
    public class PacientController : Controller
    {
        private readonly IMedicData medicData;
        private readonly IPacientData pacientData;
        private readonly IMedicamentData medicamentData;
        private readonly IConsultatieData consultatieData;
        private readonly IMedicPacientData medicPacientData;

        public PacientController(IMedicData medicData, IPacientData pacientData, IMedicamentData medicamentData, IConsultatieData consultatieData, IMedicPacientData medicPacientData)
        {
            this.medicData = medicData;
            this.pacientData = pacientData;
            this.medicamentData = medicamentData;
            this.consultatieData = consultatieData;
            this.medicPacientData = medicPacientData;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = pacientData.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Pacient pacient)
        {
            if (ModelState.IsValid)
            {
                pacientData.Add(pacient);
                return RedirectToAction("Details", new { id = pacient.Id });
            }
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = pacientData.Get(id);

            if (model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Delete(Pacient pacient)
        {
            pacientData.Delete(pacient.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = pacientData.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Pacient pacient)
        {
            if (ModelState.IsValid)
            {
                pacientData.Update(pacient);
                return RedirectToAction("Details", new { id = pacient.Id });
            }
            return View(pacient);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = new PacientMedicMedicineViewModel();
            var pacient = pacientData.Get(id);
            var medics = new List<Medic>();
            foreach(var pair in medicPacientData.GetAll())
            {
                if(pair.PacientId==id)
                {
                    var medic = medicData.Get(pair.MedicId);
                    medics.Add(medic);
                }
            }
            var consultatii = new List<ConsultatieViewModel>();
            foreach(var pair in consultatieData.GetAll())
            {
                if(pair.PacientId==id)
                {
                    var consultatie = new ConsultatieViewModel();
                    consultatie.Data = pair.Data;
                    consultatie.Diagnostic = pair.Diagnostic;
                    consultatie.DozaMedicament = pair.DozaMedicament;
                    var medicament = medicamentData.Get(pair.MedicamentId);
                    consultatie.NumeMedicament = medicament.Denumire;
                    consultatii.Add(consultatie);
                }
            }
            model.Consultatii = consultatii;
            model.Medici = medics;
            model.Pacient = pacient;

            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
    }
}
