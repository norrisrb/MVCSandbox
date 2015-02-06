using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using MVCSandbox.OpenAccess;

namespace MVCSandbox.Controllers
{
    public class CoursesController : Controller
    {
        private EntitiesModel dbContext;

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);

            this.dbContext = ContextFactory.GetContextPerRequest();
        }

        // GET: Courses
        public JsonResult GetCourses()
        {
            return Json(dbContext.Courses, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View( this.dbContext.Courses.ToList() );
        }

        // GET: Courses/Details/5
        public ActionResult Details(int id)
        {
            return View( this.dbContext.Courses.FirstOrDefault( course => course.CourseId == id ) );
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        [HttpPost]
        public ActionResult Create(Course newCourse)
        {
            try
            {
                this.dbContext.Add(newCourse);
                this.dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int id)
        {
            return View( this.dbContext.Courses.FirstOrDefault( course => course.CourseId == id ) );
        }

        // POST: Courses/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Course courseToUpdate)
        {
            try
            {
                Course originalCourse = this.dbContext.Courses.FirstOrDefault(course => course.CourseId == id);
                originalCourse.CourseName = courseToUpdate.CourseName;
                originalCourse.Yardage = courseToUpdate.Yardage;
                originalCourse.Tee = courseToUpdate.Tee;
                originalCourse.Slope = courseToUpdate.Slope;
                originalCourse.Rating = courseToUpdate.Rating;
                originalCourse.Address1 = courseToUpdate.Address1;
                originalCourse.Address2 = courseToUpdate.Address2;
                originalCourse.City = courseToUpdate.City;
                originalCourse.State = courseToUpdate.State;
                originalCourse.Zip = courseToUpdate.Zip;
                originalCourse.Website = courseToUpdate.Website;
                originalCourse.Phone = courseToUpdate.Phone;
                originalCourse.Notes = courseToUpdate.Notes;

                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int id)
        {
            return View(this.dbContext.Courses.FirstOrDefault( c => c.CourseId == id ));
        }

        // POST: Courses/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Course course = this.dbContext.Courses.FirstOrDefault(c => c.CourseId == id);
                dbContext.Delete( course );
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
