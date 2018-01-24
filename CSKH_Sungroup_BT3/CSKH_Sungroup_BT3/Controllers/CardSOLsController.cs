using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CSKH_Sungroup_BT3.Models;

namespace CSKH_Sungroup_BT3.Controllers
{
    public class CardSOLsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: CardSOLs
        public ActionResult Index()
        {
            return View(db.CardSOLs.ToList());
        }

        // GET: CardSOLs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardSOL cardSOL = db.CardSOLs.Find(id);
            if (cardSOL == null)
            {
                return HttpNotFound();
            }
            return View(cardSOL);
        }

        // GET: CardSOLs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CardSOLs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CustomerId,StartDate,TotalValue,Rate")] CardSOL cardSOL)
        {
            if (ModelState.IsValid)
            {
                db.CardSOLs.Add(cardSOL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cardSOL);
        }

        // GET: CardSOLs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardSOL cardSOL = db.CardSOLs.Find(id);
            if (cardSOL == null)
            {
                return HttpNotFound();
            }
            return View(cardSOL);
        }

        // POST: CardSOLs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CustomerId,StartDate,TotalValue,Rate")] CardSOL cardSOL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cardSOL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cardSOL);
        }

        // GET: CardSOLs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardSOL cardSOL = db.CardSOLs.Find(id);
            if (cardSOL == null)
            {
                return HttpNotFound();
            }
            return View(cardSOL);
        }

        // POST: CardSOLs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CardSOL cardSOL = db.CardSOLs.Find(id);
            db.CardSOLs.Remove(cardSOL);
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
