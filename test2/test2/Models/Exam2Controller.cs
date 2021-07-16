using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace test2.Models
{
    public class Exam2Controller : Controller
    {
        private TEST2Entities db = new TEST2Entities();

        // GET: Exam2
        public ActionResult Index()
        {
            return View(db.Exam2.ToList());
        }

        // GET: Exam2/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam2 exam2 = db.Exam2.Find(id);
            if (exam2 == null)
            {
                return HttpNotFound();
            }
            return View(exam2);
        }

        // GET: Exam2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exam2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "examID,subject,startTime,examDate,duration,classroom,faculty,status")] Exam2 exam2)
        {
            if (ModelState.IsValid)
            {
                db.Exam2.Add(exam2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exam2);
        }

        // GET: Exam2/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam2 exam2 = db.Exam2.Find(id);
            if (exam2 == null)
            {
                return HttpNotFound();
            }
            return View(exam2);
        }

        // POST: Exam2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "examID,subject,startTime,examDate,duration,classroom,faculty,status")] Exam2 exam2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exam2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exam2);
        }

        // GET: Exam2/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam2 exam2 = db.Exam2.Find(id);
            if (exam2 == null)
            {
                return HttpNotFound();
            }
            return View(exam2);
        }

        // POST: Exam2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Exam2 exam2 = db.Exam2.Find(id);
            db.Exam2.Remove(exam2);
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
