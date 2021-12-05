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
    public class LivroController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Livro
        public ActionResult Index()
        {
            return View(context.livro.OrderBy(li => li.nome));
        }

        // GET: Livro/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Livro livro = context.livro.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }
            return View(livro);
        }

        // GET: Livro/Create        
        public ActionResult Create()
        {
            ViewBag.BibliotecarioId = new SelectList(context.bibliotecario.OrderBy(b => b.nome), "BibliotecarioId", "Nome");
            ViewBag.LeitorId = new SelectList(context.leitor.OrderBy(l => l.Nome), "LeitorId", "Nome");
            return View();
        }

        // POST: Livro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Livro livro)           
        {
            context.livro.Add(livro);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Livro/Edit/5
        public ActionResult Edit(long? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            //}
            //Livro livro = context.livro.Find(id);
            //if (livro == null)
            //{
            //    return HttpNotFound();
            //}
            return View();
        }

        // POST: Livro/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Livro livro)
        {
            //if (ModelState.IsValid)
            //{
            //    context.Entry(livro).State = EntityState.Modified;
            //    context.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            return View();
        }

        // GET: Livro/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Livro livro = context.livro.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }
            return View(livro);
        }

        // POST: Livro/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Livro livro = context.livro.Find(id);
            context.livro.Remove(livro);
            context.SaveChanges();
            TempData["Message"] = "Livro *" + livro.nome.ToUpper() + " FOI REMOVIDO ";
            return RedirectToAction("Index");
        }
    
    }
}
