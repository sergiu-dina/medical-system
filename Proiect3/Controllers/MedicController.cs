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
    public class MedicController : Controller
    {
        private readonly IMedicData medicData;
        private readonly IPacientData pacientData;
        private readonly IMedicPacientData medicPacientData;

        public MedicController(IMedicData medicData, IPacientData pacientData, IMedicPacientData medicPacientData)
        {
            this.medicData = medicData;
            this.pacientData = pacientData;
            this.medicPacientData = medicPacientData;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = medicData.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Medic medic)
        {
            if (ModelState.IsValid)
            {
                medicData.Add(medic);
                return RedirectToAction("Details", new { id = medic.MedicId});
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = new MedicPacientViewModel();
            var medic = medicData.Get(id);
            var pacients = new List<Pacient>();
            foreach(var pair in medicPacientData.GetAll())
            {
                if(pair.MedicId==id)
                {
                    var pacient = pacientData.Get(pair.PacientId);
                    pacients.Add(pacient);
                }
            }
            model.Medic = medic;
            model.Pacients = pacients;
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = medicData.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Medic medic)
        {
            if (ModelState.IsValid)
            {
                medicData.Update(medic);
                return RedirectToAction("Details", new { id = medic.MedicId });
            }
            return View(medic);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = medicData.Get(id);

            if (model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Delete(Medic medic)
        {
            medicData.Delete(medic.MedicId);
            return RedirectToAction("Index");
        }
    }
}
