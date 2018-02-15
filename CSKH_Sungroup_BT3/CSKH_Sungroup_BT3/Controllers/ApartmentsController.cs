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
    public class ApartmentsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Apartments
        public ActionResult Index()
        {
            return View(db.Apartments.ToList());
        }
        //GET : Customers using Json



        //Add new Customer

        public JsonResult getAll()
        {
            {
                var apartmentList = db.Apartments.ToList();
                return Json(apartmentList, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetCustomerId()
        {
            {
                var customerList = db.Customers.ToList();
                return Json(customerList, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult getApartmentByNo(string apartNo)
        {
            
            {
                int no = Convert.ToInt32(apartNo);
                var apartmentList = db.Apartments.Find(no);
                return Json(apartmentList, JsonRequestBehavior.AllowGet);
            }
        }
        public string UpdateApartment(Apartment apart)
        {
            if (apart != null)
            {
                {
                    int no = Convert.ToInt32(apart.Id);
                    var apartmentList = db.Apartments.Where(x => x.Id == no).FirstOrDefault();
                    apartmentList.ApartmentName = apart.ApartmentName;
                    apartmentList.Address = apart.Address;
                    apartmentList.Price = apart.Price;
                    apartmentList.Status= apart.Status;
                    apartmentList.CustomerId = apart.CustomerId;
                    db.SaveChanges();
                    return " Updated";
                }
            }
            else
            {
                return "Invalid ";
            }
        }
        public string AddApartment(Apartment apart)
        {
            if (apart != null)
            {
              
                {
                    db.Apartments.Add(apart);
                    db.SaveChanges();
                    return "Apartment Updated";
                }
            }
            else
            {
                return "Invalid Apartment";
            }
        }

        public string DeleteApartment(Apartment apart)
        {
            if (apart != null)
            {
                
                {
                    int no = Convert.ToInt32(apart.Id);
                    var apartmentList = db.Apartments.Where(x => x.Id == no).FirstOrDefault();
                    db.Apartments.Remove(apartmentList);
                    db.SaveChanges();
                    return "Apartment Deleted";
                }
            }
            else
            {
                return "Invalid Apartment";
            }
        }


        // GET: Apartments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apartment apartment = db.Apartments.Find(id);
            if (apartment == null)
            {
                return HttpNotFound();
            }
            return View(apartment);
        }

        // GET: Apartments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Apartments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ApartmentName,Address,Status,Price,CustomerId")] Apartment apartment)
        {
            if (ModelState.IsValid)
            {
                db.Apartments.Add(apartment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(apartment);
        }

        // GET: Apartments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apartment apartment = db.Apartments.Find(id);
            if (apartment == null)
            {
                return HttpNotFound();
            }
            return View(apartment);
        }

        // POST: Apartments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ApartmentName,Address,Status,Price,CustomerId")] Apartment apartment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apartment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(apartment);
        }

        // GET: Apartments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apartment apartment = db.Apartments.Find(id);
            if (apartment == null)
            {
                return HttpNotFound();
            }
            return View(apartment);
        }

        // POST: Apartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Apartment apartment = db.Apartments.Find(id);
            db.Apartments.Remove(apartment);
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
