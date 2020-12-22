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
    public class MedicamentController : Controller
    {
        private readonly IMedicamentData medicamentData;
        private readonly IPacientData pacientData;
        private readonly IConsultatieData consultatieData;

        public MedicamentController(IMedicamentData medicamentData, IPacientData pacientData, IConsultatieData consultatieData )
        {
            this.medicamentData = medicamentData;
            this.pacientData = pacientData;
            this.consultatieData = consultatieData;
        }
        public IActionResult Index()
        {
            var model = medicamentData.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Medicament medicament)
        {
            if (ModelState.IsValid)
            {
                medicamentData.Add(medicament);
                return RedirectToAction("Details", new { id = medicament.MedicamentId });
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = medicamentData.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Medicament medicament)
        {
            if (ModelState.IsValid)
            {
                medicamentData.Update(medicament);
                return RedirectToAction("Details", new { id = medicament.MedicamentId });
            }
            return View(medicament);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = medicamentData.Get(id);

            if (model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Delete(Medicament medicament)
        {
            medicamentData.Delete(medicament.MedicamentId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = new MedicamentPacientViewModel();
            var medicament = medicamentData.Get(id);
            var pacients = new List<Pacient>();
            foreach (var pair in consultatieData.GetAll())
            {
                if(pair.MedicamentId==id)
                {
                    var pacient = pacientData.Get(pair.PacientId);
                    pacients.Add(pacient);
                }
            }
            model.Medicament = medicament;
            model.Pacients = pacients;
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
    }
}
