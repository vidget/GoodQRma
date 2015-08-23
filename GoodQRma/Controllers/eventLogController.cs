using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoodQRma.DAL;
using GoodQRma.Models;

namespace GoodQRma.Controllers
{
    public class eventLogController : Controller
    {
        private goodQRmaContext db = new goodQRmaContext();

        // GET: eventLog
        public ActionResult Index()
        {
            return View(db.eventLog.ToList());
        }

        // GET: eventLog/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            eventLog eventLog = db.eventLog.Find(id);
            if (eventLog == null)
            {
                return HttpNotFound();
            }
            return View(eventLog);
        }

        // GET: eventLog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: eventLog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "eventLogID,userID,eventID")] eventLog eventLog)
        {
            if (ModelState.IsValid)
            {
                db.eventLog.Add(eventLog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eventLog);
        }

        // GET: eventLog/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            eventLog eventLog = db.eventLog.Find(id);
            if (eventLog == null)
            {
                return HttpNotFound();
            }
            return View(eventLog);
        }

        // POST: eventLog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "eventLogID,userID,eventID")] eventLog eventLog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventLog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventLog);
        }

        // GET: eventLog/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            eventLog eventLog = db.eventLog.Find(id);
            if (eventLog == null)
            {
                return HttpNotFound();
            }
            return View(eventLog);
        }

        // POST: eventLog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            eventLog eventLog = db.eventLog.Find(id);
            db.eventLog.Remove(eventLog);
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
