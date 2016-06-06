using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OSHelpLine.Models;

namespace OSHelpLine.Controllers
{
    public class HelpTicketsController : Controller
    {
        private OSHelpLineEntities db = new OSHelpLineEntities();

        // GET: HelpTickets
        public ActionResult Index()
        {
            var helpTickets = db.HelpTickets.Include(h => h.Instructor).Include(h => h.Location).Include(h => h.Status).Include(h => h.Student);
            return View(helpTickets.ToList());
        }

        // GET: HelpTickets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HelpTicket helpTicket = db.HelpTickets.Find(id);
            if (helpTicket == null)
            {
                return HttpNotFound();
            }
            return View(helpTicket);
        }

        // GET: HelpTickets/Create
        public ActionResult Create()
        {
            ViewBag.InstructorId = new SelectList(db.Instructors, "InstructorId", "FullName");
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "LocationName");
            ViewBag.StatusId = new SelectList(db.Status, "StatusId", "StatusName");
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FullName");
            return View();
        }

        // POST: HelpTickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HelpTicketId,StudentId,InstructorId,LocationId,StatusId,TimeIn,Topic,Description,TimeDone")] HelpTicket helpTicket)
        {
            if (ModelState.IsValid)
            {
                db.HelpTickets.Add(helpTicket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.InstructorId = new SelectList(db.Instructors, "InstructorId", "FullName", helpTicket.InstructorId);
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "LocationName", helpTicket.LocationId);
            ViewBag.StatusId = new SelectList(db.Status, "StatusId", "StatusName", helpTicket.StatusId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FullName", helpTicket.StudentId);
            return View(helpTicket);
        }

        // GET: HelpTickets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HelpTicket helpTicket = db.HelpTickets.Find(id);
            if (helpTicket == null)
            {
                return HttpNotFound();
            }
            ViewBag.InstructorId = new SelectList(db.Instructors, "InstructorId", "FullName", helpTicket.InstructorId);
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "LocationName", helpTicket.LocationId);
            ViewBag.StatusId = new SelectList(db.Status, "StatusId", "StatusName", helpTicket.StatusId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FullName", helpTicket.StudentId);
            return View(helpTicket);
        }

        // POST: HelpTickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HelpTicketId,StudentId,InstructorId,LocationId,StatusId,TimeIn,Topic,Description,TimeDone")] HelpTicket helpTicket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(helpTicket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InstructorId = new SelectList(db.Instructors, "InstructorId", "FullName", helpTicket.InstructorId);
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "LocationName", helpTicket.LocationId);
            ViewBag.StatusId = new SelectList(db.Status, "StatusId", "StatusName", helpTicket.StatusId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FullName", helpTicket.StudentId);
            return View(helpTicket);
        }

        // GET: HelpTickets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HelpTicket helpTicket = db.HelpTickets.Find(id);
            if (helpTicket == null)
            {
                return HttpNotFound();
            }
            return View(helpTicket);
        }

        // POST: HelpTickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HelpTicket helpTicket = db.HelpTickets.Find(id);
            db.HelpTickets.Remove(helpTicket);
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
