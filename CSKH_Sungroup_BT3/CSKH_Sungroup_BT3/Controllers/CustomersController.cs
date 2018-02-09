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
    public class CustomersController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        //GET : Customers using Json
        public JsonResult GetAllCustomers()
        {

                List<Customer> cus = db.Customers.ToList();
                return Json(cus, JsonRequestBehavior.AllowGet);
        }


        //Add new Customer

        public JsonResult AddNewCustomer(Customer cus)
        {
            if(cus != null)
            {
                db.Customers.Add(cus);
                db.SaveChanges();
                return Json(cus, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Some Error Occured");
            }
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Passport,Address,Email,PhoneNumber")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public string UpdateCustomer(Customer cus)
        {
            if (cus != null)
            {
                Customer customer =  db.Customers.Where(x => x.Id == cus.Id).FirstOrDefault();
                customer.Passport = cus.Passport;
                customer.Email = cus.Email;
                customer.Address = cus.Address;
                customer.PhoneNumber = cus.PhoneNumber;
                db.SaveChanges();

                return "Customer updated";
            }
            return "somgthing went wrong.";
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult DeleteCustomer(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
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
