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
using GymTrack.ViewModels;

namespace GymTrack.Controllers
{
    public class ExerciseDayProgramsController : Controller
    {
        private GymTrackerContext db = new GymTrackerContext();

        // GET: ExerciseDayPrograms
        public ActionResult Index()
        {
            return View(db.ExerciseDayPrograms.ToList());
        }

        // GET: ExerciseDayPrograms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExerciseDayProgram exerciseDayProgram = db.ExerciseDayPrograms.Find(id);
            if (exerciseDayProgram == null)
            {
                return HttpNotFound();
            }
            return View(exerciseDayProgram);
        }

        // GET: ExerciseDayPrograms/Create
        public ActionResult Create()
        {
            var query = from e in db.Exercises
                        orderby e.ExerciseName
                        select e;

            SelectList sl = new SelectList(query, "ExerciseID", "ExerciseName", null);
            ViewBag.ExerciseListID = new SelectList(query, "ExerciseID", "ExerciseName", null);

            return View(sl);
        }

        // POST: ExerciseDayPrograms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ExerciseDayName,Description")] ExerciseDayProgram exerciseDayProgram)
        {
            if (ModelState.IsValid)
            {
                db.ExerciseDayPrograms.Add(exerciseDayProgram);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exerciseDayProgram);
        }

        // GET: ExerciseDayPrograms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExerciseDayProgram exerciseDayProgram = db.ExerciseDayPrograms.Find(id);
            if (exerciseDayProgram == null)
            {
                return HttpNotFound();
            }
            return View(exerciseDayProgram);
        }

        // POST: ExerciseDayPrograms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ExerciseDayName,Description")] ExerciseDayProgram exerciseDayProgram)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exerciseDayProgram).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exerciseDayProgram);
        }

        // GET: ExerciseDayPrograms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExerciseDayProgram exerciseDayProgram = db.ExerciseDayPrograms.Find(id);
            if (exerciseDayProgram == null)
            {
                return HttpNotFound();
            }
            return View(exerciseDayProgram);
        }

        // POST: ExerciseDayPrograms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExerciseDayProgram exerciseDayProgram = db.ExerciseDayPrograms.Find(id);
            db.ExerciseDayPrograms.Remove(exerciseDayProgram);
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
