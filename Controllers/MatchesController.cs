﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ReffAppT.Models;

namespace ReffAppT.Controllers
{
    public class MatchesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Matches
        public ActionResult Index()
        {
            //    if (db.Matches.FirstOrDefault(x => x.RefId >= 0) == null)

           
            return View(db.Matches.ToList());
            
           // throw new Exception("brak rekordow");

            //var user = db.Referees.FirstOrDefault(x => x.RefId = RefId);
            //  var user = db.Referees.FirstOrDefault(x => x.RefId.Equals(referee RefId);
           // ViewBag.RefId = new SelectList(db.Referees, "RefId", "FullName");
        }

        // GET: Matches/Details/5
        public ActionResult Details(int? id)
        {
            ViewBag.RefId = new SelectList(db.Referees, "RefId", "FullName");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Match match = db.Matches.Find(id);
            if (match == null)
            {
                return HttpNotFound();
            }
            return View(match);
        }

        // GET: Matches/Create
        public ActionResult Create()
        {
            ViewBag.RefId = new SelectList(db.Referees, "RefId", "FullName");
            return View();
        }

        // POST: Matches/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MatchId,HostTeam,GuestTeam,GymAddress,Liga,Category,AddDate,RefId")] Match match)
        {
            ViewBag.RefId = new SelectList(db.Referees, "RefId", "FullName");
            if (ModelState.IsValid)
            {
                db.Matches.Add(match);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(match);
        }

        // GET: Matches/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.RefId = new SelectList(db.Referees, "RefId", "FullName");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Match match = db.Matches.Find(id);
            if (match == null)
            {
                return HttpNotFound();
            }
            return View(match);
        }

        // POST: Matches/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MatchId,HostTeam,GuestTeam,GymAddress,Liga,Category,AddDate,RefId")] Match match)
        {
            ViewBag.RefId = new SelectList(db.Referees, "RefId", "FullName");
            if (ModelState.IsValid)
            {
                db.Entry(match).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(match);
        }

        // GET: Matches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Match match = db.Matches.Find(id);
            if (match == null)
            {
                return HttpNotFound();
            }
            return View(match);
        }

        // POST: Matches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Match match = db.Matches.Find(id);
            db.Matches.Remove(match);
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
