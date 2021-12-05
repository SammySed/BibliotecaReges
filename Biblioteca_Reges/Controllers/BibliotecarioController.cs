using Biblioteca_Reges.Context;
using Biblioteca_Reges.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca_Reges.Controllers
{
    public class BibliotecarioController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Bibliotecario
        public ActionResult Index()
        {
            return View(context.bibliotecario.OrderBy(c => c.nome));
        }

        // GET: Bibliotecario/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Bibliotecario bibliotecario = context.bibliotecario.Find(id);
            if (bibliotecario == null)
            {
                return HttpNotFound();
            }
            return View(bibliotecario);
        }

        // GET: Bibliotecario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bibliotecario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Bibliotecario bibliotecario)
        {
            context.bibliotecario.Add(bibliotecario);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Bibliotecario/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Bibliotecario bibliotecario = context.bibliotecario.Find(id);
            if (bibliotecario == null)
            {
                return HttpNotFound();
            }
            return View(bibliotecario);
        }

        // POST: Bibliotecario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Bibliotecario bibliotecario)
        {
            if (ModelState.IsValid)
            {
                context.Entry(bibliotecario).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bibliotecario);
        }
       
        // POST: Bibliotecario/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Bibliotecario bibliotecario = context.bibliotecario.Find(id);
            if (bibliotecario == null)
            {
                return HttpNotFound();
            }
            return View(bibliotecario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Bibliotecario bibliotecario = context.bibliotecario.Find(id);
            context.bibliotecario.Remove(bibliotecario);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
