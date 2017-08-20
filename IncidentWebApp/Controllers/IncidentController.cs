using ClientApi;
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

            model.Incidents = await IncidentApi.GetAllIncidentsAsync();

            return View(model);
        }

        // GET: Incident/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Incident/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Incident/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Incident/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Incident/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Incident/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
