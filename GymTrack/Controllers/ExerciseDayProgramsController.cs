﻿using System;
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
    public class ExerciseDayProgramsController : Controller
    {
        private GymTrackerContext db = new GymTrackerContext();

        // GET: ExerciseDayPrograms
        public ActionResult Index()
        {
            return View(db.ExerciseDayProgram.ToList());
        }

        // GET: ExerciseDayPrograms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExerciseDayProgram exerciseDayProgram = db.ExerciseDayProgram.Find(id);
            if (exerciseDayProgram == null)
            {
                return HttpNotFound();
            }
            return View(exerciseDayProgram);
        }

        // GET: ExerciseDayPrograms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExerciseDayPrograms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ExerciseDayName,ExerciseID,PlannedSets,PlannedReps")] ExerciseDayProgram exerciseDayProgram)
        {
            if (ModelState.IsValid)
            {
                db.ExerciseDayProgram.Add(exerciseDayProgram);
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
            ExerciseDayProgram exerciseDayProgram = db.ExerciseDayProgram.Find(id);
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
        public ActionResult Edit([Bind(Include = "ID,ExerciseDayName,ExerciseID,PlannedSets,PlannedReps")] ExerciseDayProgram exerciseDayProgram)
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
            ExerciseDayProgram exerciseDayProgram = db.ExerciseDayProgram.Find(id);
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
            ExerciseDayProgram exerciseDayProgram = db.ExerciseDayProgram.Find(id);
            db.ExerciseDayProgram.Remove(exerciseDayProgram);
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
