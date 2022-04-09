using StudentMVC.Models;
using StudentMVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMVC.Controllers
{
    public class StudentController : Controller
    {
        private StudentServices _stuServices;
        // GET: Student
        public ActionResult List()
        {
            _stuServices = new StudentServices();

            var model = _stuServices.GetStudentList();

            return View(model);
        }

        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(StudentModel model)
        {
            _stuServices = new StudentServices();

            _stuServices.InsertStudent(model);

            return RedirectToAction("List");
        }

        public ActionResult EditStudent(int Student_ID = 0)
        {
            _stuServices = new StudentServices();

            var model = _stuServices.GetEditById(Student_ID);

            return View(model);
        }
        [HttpPost]
        public ActionResult EditStudent(StudentModel model)
        {
            _stuServices = new StudentServices();

            _stuServices.UpdateStudent(model);

            return RedirectToAction("List");
        }

        //[HttpPost]
        public ActionResult DeleteStudent(int Student_ID)
        {
            _stuServices = new StudentServices();

            _stuServices.DeleteStudent(Student_ID);

            return RedirectToAction("List");
        }

    }
}