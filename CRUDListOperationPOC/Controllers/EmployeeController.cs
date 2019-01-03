using CRUDListOperationPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
//using System.Web.Http;
using System.Web.Mvc;
using CRUDListOperationPOC.DataAccessLayer;
using System.Data.Entity.Infrastructure;

namespace CRUDListOperationPOC.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeContext  db = new EmployeeContext();
       
        public ActionResult Index()
        {
            var emps = from e in db.Employees 
                           select e;
            return View(emps);
        }

        public ActionResult InsertEmployee()
        {
           
            return View();
        }

       [HttpPost]
       [ValidateAntiForgeryToken]
        public ActionResult Insert(EmployeeDetails employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (RetryLimitExceededException)
            {
                
                ModelState.AddModelError("", "Unable to save changes.");
            }
            return View(employee);
            //return RedirectToAction("Index");
        }
        public ActionResult EditEmployee(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDetails employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var empUpdate = db.Employees .Find(id);
            if (TryUpdateModel(empUpdate, "",
               new string[] { "LastName", "FirstMidName", "EnrollmentDate" }))
            {
                try
                {
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (RetryLimitExceededException)
                {
                    
                    ModelState.AddModelError("", "Unable to save changes.");
                }
            }
            return View(empUpdate);
        }

        public ActionResult DeleteEmployee(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed.";
            }
            EmployeeDetails employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            
            try
            {
                EmployeeDetails  emp = db.Employees.Find(id);
                db.Employees.Remove(emp);
                db.SaveChanges();
            }
            catch (RetryLimitExceededException)
            {
                
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
            // return RedirectToAction("Index");
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
