using ClientApi;
using IncidentWebApp.Classes;
using IncidentWebApp.Models.Incident;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IncidentWebApp.Controllers
{
    public class IncidentController : Controller
    {
        // GET: Incident
        public async Task<ActionResult> Index()
        {
            var model = new IncidentListModel();

            model.Incidents = await IncidentClientApi.GetAllIncidentsAsync();

            return View(model);
        }
        
        public ActionResult Create()
        {
            var model = new IncidentCreateModel();

            model.IncidentTypeList = Utils.GetAllIncidentTypeList();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public async Task<ActionResult> Create(IncidentCreateModel model)
        {
            if (ModelState.IsValid)
            {
                int idCreated = await IncidentClientApi.CreateIncidentAsync(new BusinessObject.Incident()
                {
                    IncidentName = model.IncidentName,
                    CreatedDate = model.CreatedDate,
                    NumberPeople = model.NumberPeople,
                    IsUrgent = model.IsUrgent,
                    IncidentType = model.SelectedIncidentType
                });

                return RedirectToAction("Index");
            }

            model.IncidentTypeList = Utils.GetAllIncidentTypeList();

            return View(model);           
        }
        
        public async Task<ActionResult> Edit(int id)
        {
            var incident = await IncidentClientApi.GetIncidentByIdAsync(id);

            var model = new IncidentCreateModel(incident);         

            model.IncidentTypeList = Utils.GetAllIncidentTypeList();
            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken()]
        public async Task<ActionResult> Edit(int id, IncidentCreateModel model)
        {
            if (ModelState.IsValid)
            {
                var incident = model.GetIncidentObj();
                await IncidentClientApi.UpdateIncidentAsync(incident);
                return RedirectToAction("Index");
            }

            model.IncidentTypeList = Utils.GetAllIncidentTypeList();
            return View(model);
        }
        
        public async Task<ActionResult> Delete(int id)
        {
            await IncidentClientApi.DeleteIncidentAsync(id);
            return RedirectToAction("Index");
        }
    }
}
