using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance2.Models;

namespace CarInsurance2.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }


        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            
            if (ModelState.IsValid)
            {
                // Calculating Quote
                double quote = 50; // Starting with base 50
                double total;
                int now = DateTime.Now.Year;
                int age = now - insuree.DateOfBirth.Year;

                // Age additions
                if (age <= 18)
                {
                    quote += 100;
                }
                else if ( age >= 19 && age <= 25)
                {
                    quote += 50;
                }
                else
                {
                    quote += 25;
                }

                // Car year additions
                if (insuree.CarYear < 2000)
                {
                    quote += 25;
                }
                if (insuree.CarYear > 2015)
                {
                    quote += 25;
                }

                // Car make additions
                if (insuree.CarModel == "Porsche")
                {
                    quote += 25;
                }
                if (insuree.CarModel == "Porsche" && insuree.CarModel == "911 Carrera")
                {
                    quote += 25;
                }

                // Speeding ticket addition(s)
                if (insuree.SpeedingTickets > 0)
                {
                    // add $10 to the quote for every speeding ticket
                    for (int tickets = insuree.SpeedingTickets; tickets > 0; tickets--)
                    {
                        quote += 10;
                    }
                }

                // Total for quote
                total = quote;

                // DUI addition
                if (insuree.DUI)
                {
                    total += (quote * .25); // Add 25% of quote to total
                }

                // Full coverage addition if full coverage box is checked
                if (insuree.CoverageType == true)
                {
                    total += (quote * .5); // Add 50% of quote to total
                }
                
                // Assign total to Quote
                insuree.Quote = (decimal)total;

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
