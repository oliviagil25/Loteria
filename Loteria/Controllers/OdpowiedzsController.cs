using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Loteria.Models;
using Loteria.Models.DbModels;

namespace Loteria.Controllers
{
    public class OdpowiedzsController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Odpowiedzs
        public ActionResult Index()
        {
            var odpowiedzi = db.Odpowiedzi.Include(o => o.Pytanie);
            return View(odpowiedzi.ToList());
        }

        // GET: Odpowiedzs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odpowiedz odpowiedz = db.Odpowiedzi.Find(id);
            if (odpowiedz == null)
            {
                return HttpNotFound();
            }
            return View(odpowiedz);
        }

        // GET: Odpowiedzs/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.PytanieId = new SelectList(db.Pytania, "PytanieId", "tresc");
            return View(new Odpowiedz());
        }

        // POST: Odpowiedzs/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OdpowiedzId,tresc,poprawnoscOdpowiedzi,PytanieId")] Odpowiedz odpowiedz)
        {
            if (ModelState.IsValid)
            {
                db.Odpowiedzi.Add(odpowiedz);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PytanieId = new SelectList(db.Pytania, "PytanieId", "tresc", odpowiedz.PytanieId);
            return View(odpowiedz);
        }

        // GET: Odpowiedzs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odpowiedz odpowiedz = db.Odpowiedzi.Find(id);
            if (odpowiedz == null)
            {
                return HttpNotFound();
            }
            ViewBag.PytanieId = new SelectList(db.Pytania, "PytanieId", "tresc", odpowiedz.PytanieId);
            return View(odpowiedz);
        }

        // POST: Odpowiedzs/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OdpowiedzId,tresc,poprawnoscOdpowiedzi,PytanieId")] Odpowiedz odpowiedz)
        {
            if (ModelState.IsValid)
            {
                db.Entry(odpowiedz).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PytanieId = new SelectList(db.Pytania, "PytanieId", "tresc", odpowiedz.PytanieId);
            return View(odpowiedz);
        }

        // GET: Odpowiedzs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Odpowiedz odpowiedz = db.Odpowiedzi.Find(id);
            if (odpowiedz == null)
            {
                return HttpNotFound();
            }
            return View(odpowiedz);
        }

        // POST: Odpowiedzs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Odpowiedz odpowiedz = db.Odpowiedzi.Find(id);
            db.Odpowiedzi.Remove(odpowiedz);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
