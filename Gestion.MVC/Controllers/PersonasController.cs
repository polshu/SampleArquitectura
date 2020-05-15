using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using Gestion.Entities;
using Gestion.Services;
//using Gestion.MVC.Models;

namespace Gestion.MVC.Controllers {
    public class PersonasController : Controller {
        //private GestionMVCContext db = new GestionMVCContext();

        // GET: Personas
        public ActionResult Index() {
            List<Persona> personasList;

            personasList = PersonasService.GetAll();
            return View(personasList);
        }

        // GET: Personas/Details/5
        public ActionResult Details(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = PersonasService.GetById(id.GetValueOrDefault());
            if (persona == null) {
                return HttpNotFound();
            }
            return View(persona);
        }

        // GET: Personas/Create
        public ActionResult Create() {
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Email,Activo")] Persona persona) {
            int     intNewId;
            string  strErrores = "";

            if (ModelState.IsValid) {
                intNewId = PersonasService.InsertValid(persona, out strErrores);
                if (intNewId > 0) {
                    return RedirectToAction("Index");
                } else {
                    ViewBag.Errores = strErrores;
                    return View(persona);
                }
            }

            return View(persona);
        }

        //protected override void Dispose(bool disposing) {
        //    if (disposing) {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
