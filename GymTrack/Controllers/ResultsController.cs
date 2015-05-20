using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GymTrack.DAL;
using GymTrack.Models;

namespace GymTrack.Controllers
{
    public class ResultsController : Controller
    {
        private GymTrackerContext db = new GymTrackerContext();

        // GET: Results
        public ActionResult Index()
        {
            var results = db.Results.Include(r => r.Exercise).Include(r => r.ExerciseDayProgram);
            return View(results.ToList());
        }

        // GET: Results/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Results results = db.Results.Find(id);
            if (results == null)
            {
                return HttpNotFound();
            }
            return View(results);
        }

        // GET: Results/Create
        public ActionResult Create()
        {
            ViewBag.ExerciseID = new SelectList(db.Exercises, "ID", "ExerciseName");
            ViewBag.ExerciseDayProgramID = new SelectList(db.ExerciseDayPrograms, "ID", "ExerciseDayName");
            return View();
        }

        // POST: Results/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ExerciseID,ExerciseDayProgramID,ExerciseDate,SetNumber,Weight,Reps")] Results results)
        {
            if (ModelState.IsValid)
            {
                db.Results.Add(results);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ExerciseID = new SelectList(db.Exercises, "ID", "ExerciseName", results.ExerciseID);
            ViewBag.ExerciseDayProgramID = new SelectList(db.ExerciseDayPrograms, "ID", "ExerciseDayName", results.ExerciseDayProgramID);
            return View(results);
        }

        // GET: Results/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Results results = db.Results.Find(id);
            if (results == null)
            {
                return HttpNotFound();
            }
            ViewBag.ExerciseID = new SelectList(db.Exercises, "ID", "ExerciseName", results.ExerciseID);
            ViewBag.ExerciseDayProgramID = new SelectList(db.ExerciseDayPrograms, "ID", "ExerciseDayName", results.ExerciseDayProgramID);
            return View(results);
        }

        // POST: Results/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ExerciseID,ExerciseDayProgramID,ExerciseDate,SetNumber,Weight,Reps")] Results results)
        {
            if (ModelState.IsValid)
            {
                db.Entry(results).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ExerciseID = new SelectList(db.Exercises, "ID", "ExerciseName", results.ExerciseID);
            ViewBag.ExerciseDayProgramID = new SelectList(db.ExerciseDayPrograms, "ID", "ExerciseDayName", results.ExerciseDayProgramID);
            return View(results);
        }

        // GET: Results/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Results results = db.Results.Find(id);
            if (results == null)
            {
                return HttpNotFound();
            }
            return View(results);
        }

        // POST: Results/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Results results = db.Results.Find(id);
            db.Results.Remove(results);
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
