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
    public class LeitorController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Leitor
        public ActionResult Index()
        {
            return View(context.leitor.OrderBy(c => c.Nome));
        }

        // GET: Leitor/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Leitor leitor = context.leitor.Find(id);
            if (leitor == null)
            {
                return HttpNotFound();
            }
            return View(leitor);
        }

        // GET: Leitor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Leitor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Leitor leitor)
        {
            context.leitor.Add(leitor);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Leitor/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Leitor leitor = context.leitor.Find(id);
            if (leitor == null)
            {
                return HttpNotFound();
            }
            return View(leitor);
        }

        // POST: Leitor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Leitor leitor)
        {
            if (ModelState.IsValid)
            {
                context.Entry(leitor).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leitor);
        }

        // GET: Leitor/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Leitor leitor = context.leitor.Find(id);
            if (leitor == null)
            {
                return HttpNotFound();
            }
            return View(leitor);
        }

        // POST: Leitor/Delete/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Leitor leitor = context.leitor.Find(id);
            context.leitor.Remove(leitor);
            context.SaveChanges();
            TempData["Message"] = "Leitor *" + leitor.Nome.ToUpper() + " FOI REMOVIDO ";
            return RedirectToAction("Index");
        }
    
    }
}
