using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using MVCSandbox.OpenAccess;

namespace MVCSandbox.Controllers
{
    public class CourseMaintenanceController : Controller
    {
        private EntitiesModel dbContext;

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);

            this.dbContext = ContextFactory.GetContextPerRequest();
        }
        
        // GET: CourseMaintenance
        public JsonResult GetCourseMaintenance()
        {
            return Json(dbContext.CourseMaintenances, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View(this.dbContext.CourseMaintenances.ToList());
        }

        // GET: CourseMaintenance/Details/5
        public ActionResult Details(int id)
        {
            return View(this.dbContext.CourseMaintenances.FirstOrDefault(courseMaint => courseMaint.CourseMaintId == id));
        }

        // GET: CourseMaintenance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseMaintenance/Create
        [HttpPost]
        public ActionResult Create(CourseMaintenance newCourseMaint)
        {
            try
            {
                this.dbContext.Add(newCourseMaint);
                this.dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseMaintenance/Edit/5
        public ActionResult Edit(int id)
        {
            return View(this.dbContext.CourseMaintenances.FirstOrDefault(courseMaint => courseMaint.CourseMaintId == id));
        }

        // POST: CourseMaintenance/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CourseMaintenance courseMaintToUpdate)
        {
            try
            {
                CourseMaintenance origionalCourseMaint =
                    this.dbContext.CourseMaintenances.FirstOrDefault(courseMaint => courseMaint.CourseMaintId == id);

                origionalCourseMaint.CourseId = courseMaintToUpdate.CourseId;
                origionalCourseMaint.MaintenanceDate = courseMaintToUpdate.MaintenanceDate;
                origionalCourseMaint.MaintenanceType = courseMaintToUpdate.MaintenanceType;
                origionalCourseMaint.FirmDate = courseMaintToUpdate.FirmDate;
                
                this.dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseMaintenance/Delete/5
        public ActionResult Delete(int id)
        {
            return View(this.dbContext.CourseMaintenances.FirstOrDefault(courseMaint => courseMaint.CourseMaintId == id));
        }

        // POST: CourseMaintenance/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                CourseMaintenance courseMaintToDelete =
                    this.dbContext.CourseMaintenances.FirstOrDefault(courseMaint => courseMaint.CourseMaintId == id);

                this.dbContext.Delete(courseMaintToDelete);

                this.dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public JsonResult GetCourseList()
        {

            var allCourses = dbContext.Courses.ToList();

            var results =
                allCourses.Select(x => new Course() { CourseId = x.CourseId, CourseName = x.CourseName }).ToList();
            return Json(results, JsonRequestBehavior.AllowGet);

        }
    }
}
