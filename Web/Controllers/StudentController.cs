using Domain.Entities;
using Services;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly RecordSheetService<Student> studentservice;
        private readonly RecordSheetService<Course> courseservice;
        private readonly RecordSheetService<Grade> gradeservice;
        private readonly RecordSheetService<Department> depteservice;

        public StudentController()
        {
            studentservice = new RecordSheetService<Student>();
            courseservice = new RecordSheetService<Course>();
            gradeservice = new RecordSheetService<Grade>();
            depteservice = new RecordSheetService<Department>();
        }
        // GET: Student
        public ActionResult AddRecord()
        {
            ViewBagData();
            return View();
        }

        public ActionResult RecordList()
        {
            return View();
        }

        public ActionResult GetData()
        {
            var students = studentservice.GetAll();
            return Json(new { data = students }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddRecord(RecordViewModel std)
        {
            ViewBagData();

            if (ModelState.IsValid)
            {
                var student = new Student
                {
                    Name = std.Name,
                    DepartmentId = std.DepartmentId,
                    CourseId = std.CourseId,
                    Gradeid = std.GradeId
                };

                studentservice.Add(student);
            }
            return View();
        }

        private void ViewBagData()
        {
            ViewBag.Courses = courseservice.GetAll();
            ViewBag.Grade = gradeservice.GetAll();
            ViewBag.Depts = depteservice.GetAll();
        }
    }
}