using ProyectoPostres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPostres.Controllers
{
    public class RecetaController : Controller
    {
        readonly RecetaDbConnection db = new RecetaDbConnection();
        // GET: Receta
        public ActionResult Index()
        {
            var receta = db.Recetas.ToList();
            return View(receta);
        }
        // GET: Receta/Details/5
        public ActionResult Details(int id)
        {
            var receta = db.Recetas.Find(id);
            return View(receta);
        }

        // GET: Receta/Create
        public ActionResult Create(int id)
        {
            var receta = db.Recetas.Find(id);
            return View(receta);
        }

        // POST: Receta/Create
        [HttpPost]
        public ActionResult Create(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var receta = db.Recetas.Find(id);
               /* db.Recetas.Create(receta);*/
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Receta/Edit/5
        public ActionResult Edit(int id)
        {
            var receta = db.Recetas.Find(id);
            return View(receta);
        }

        // POST: Receta/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Receta c)
        {
            try
            {
                // TODO: Add update logic here

                var receta = db.Recetas.Find(id);
                receta.Nombre_Postre = c.Nombre_Postre;
                receta.Ingredientes = c.Ingredientes;
                receta.Receta_Postre = c.Receta_Postre;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Receta/Delete/5
        public ActionResult Delete(int id)
        {

            var receta = db.Recetas.Find(id);

            return View(receta);
        }
        // POST: Receta/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var receta = db.Recetas.Find(id);
                db.Recetas.Remove(receta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
    }
}