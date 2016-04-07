using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GP2.Models;

namespace GP2.Controllers
{
    public class WorkItemsController : Controller
    {
        private GPContext db = new GPContext();

        // GET: WorkItems
        public ActionResult Index()
        {
            var workItems = db.WorkItems.Include(w => w.WorkOrder);
            return View(workItems.ToList());
        }

        // GET: WorkItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkItem workItem = db.WorkItems.Find(id);
            if (workItem == null)
            {
                return HttpNotFound();
            }
            return View(workItem);
        }

        // GET: WorkItems/Create
        public ActionResult Create()
        {
            ViewBag.WorkOrderID = new SelectList(db.WorkOrders, "WorkOrderID", "WorkOrderID");
            return View();
        }

        // POST: WorkItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkItemID,Description,Quantity,UnitPrice,FinalPrice,WorkOrderID")] WorkItem workItem)
        {
            if (ModelState.IsValid)
            {
                db.WorkItems.Add(workItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.WorkOrderID = new SelectList(db.WorkOrders, "WorkOrderID", "WorkOrderID", workItem.WorkOrderID);
            return View(workItem);
        }

        // GET: WorkItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkItem workItem = db.WorkItems.Find(id);
            if (workItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.WorkOrderID = new SelectList(db.WorkOrders, "WorkOrderID", "WorkOrderID", workItem.WorkOrderID);
            return View(workItem);
        }

        // POST: WorkItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkItemID,Description,Quantity,UnitPrice,FinalPrice,WorkOrderID")] WorkItem workItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.WorkOrderID = new SelectList(db.WorkOrders, "WorkOrderID", "WorkOrderID", workItem.WorkOrderID);
            return View(workItem);
        }

        // GET: WorkItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkItem workItem = db.WorkItems.Find(id);
            if (workItem == null)
            {
                return HttpNotFound();
            }
            return View(workItem);
        }

        // POST: WorkItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkItem workItem = db.WorkItems.Find(id);
            db.WorkItems.Remove(workItem);
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
