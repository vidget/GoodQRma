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
using Rotativa;

namespace GoodQRma.Controllers
{
    public class EventController : Controller
    {
        private goodQRmaContext db = new goodQRmaContext();

        // GET: Event
        /*public ActionResult Index(string id)
        {
            string searchString = id;

            var events = from e in db.Events
                         select e;

            if (!String.IsNullOrEmpty(searchString))
            {
                events = events.Where(s => s.eventType.Contains(searchString));
            }

            return View(events);
        }*/
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var events = from s in db.Events
                           select s;

            if (!string.IsNullOrEmpty(searchString))
            {
                events = events.Where(s => s.eventType.Contains(searchString));
                    
            }
            switch (sortOrder)
            {
                case "name_desc":
                    events = events.OrderByDescending(s => s.eventType);
                    break;
                case "Date":
                    events = events.OrderBy(s => s.eventTime);
                    break;
                case "date_desc":
                    events = events.OrderByDescending(s => s.eventDate);
                    break;
                default:
                    events = events.OrderBy(s => s.city);
                    break;
            }
            return View(events.ToList());
        }
                
        public ActionResult EventPoster(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }



            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }



            //return new RouteAsPdf("Poster", new { name = "EventPoster" }) { FileName = "Poster.pdf" };


            return View("EventPoster", "_Layout2", @event);
        }

        // GET: Event/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "eventID,userID,image,name,description,eventType,eventDate,eventTime,numVolunteersNeeded,address1,address2,city,state,zipCode,country,contact,phone,gpsLong,gpsLat,eventURL")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(@event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(@event);
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Event/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "eventID,userID,image,name,description,eventType,eventDate,eventTime,numVolunteersNeeded,address1,address2,city,state,zipCode,country,contact,phone,gpsLong,gpsLat,eventURL")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@event);
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event @event = db.Events.Find(id);
            db.Events.Remove(@event);
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
