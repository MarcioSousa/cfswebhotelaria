using cfshotelaria.Contexts;
using cfshotelaria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace cfshotelaria.Controllers
{
    public class QuartosController : Controller
    {
        private readonly EFContext context = new EFContext();

        // GET: Quartos
        public ActionResult Index()
        {
            return View(context.Quartos.OrderBy(q=>q.Numero));
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Quarto quarto)
        {
            context.Quartos.Add(quarto);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(long? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarto quarto = context.Quartos.Find(id);
            if(quarto == null)
            {
                return HttpNotFound();
            }
            return View(quarto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Quarto quarto)
        {
            if (ModelState.IsValid)
            {
                context.Entry(quarto).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quarto);
        }
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarto quarto = context.Quartos.Find(id);
            if (quarto == null)
            {
                return HttpNotFound();
            }
            return View(quarto);
        }
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarto quarto = context.Quartos.Find(id);
            if (quarto == null)
            {
                return HttpNotFound();
            }
            return View(quarto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Quarto quarto = context.Quartos.Find(id);
            context.Quartos.Remove(quarto);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}