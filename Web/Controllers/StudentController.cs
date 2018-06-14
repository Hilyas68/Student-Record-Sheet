using Domain.Entities;
using Services;
using System.Web.Mvc;

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

        public ActionResult DeleteRecord(Student std)
        {
            studentservice.Delete(std);
            return Json(new { success = true, message = "Deleted Successfully" }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult EditRecord(Student std)
        {
            ViewBagData();
            ViewBag.SingleStudent = studentservice.GetSingle(std.Id);

            return View(ViewBag.SingleStudent);
        }

        [HttpPost]
        public ActionResult EditRecord(Student std, int id)
        {
            if (!ModelState.IsValid) return View();

            studentservice.Edit(std);
            return RedirectToAction("RecordList", "Student");
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
        public ActionResult AddRecord(Student std)
        {
            ViewBagData();
            if (!ModelState.IsValid) return View();

            studentservice.Add(std);
            return RedirectToAction("RecordList", "Student");
        }


        private void ViewBagData()
        {
            ViewBag.Courses = courseservice.GetAll();
            ViewBag.Grade = gradeservice.GetAll();
            ViewBag.Depts = depteservice.GetAll();
        }
    }
}