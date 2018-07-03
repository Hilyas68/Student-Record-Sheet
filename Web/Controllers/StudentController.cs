using Domain.Entities;
using Services.Interfaces;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IServices<Student> studentservice;
        private readonly IServices<Course> courseservice;
        private readonly IServices<Grade> gradeservice;
        private readonly IServices<Department> depteservice;
        //IRepository<Student> repo = new StudentRecordRepo<Student>();

        public StudentController(IServices<Student> studentservice, IServices<Course> courseservice, IServices<Grade> gradeservice, IServices<Department> depteservice)
        {
            this.studentservice = studentservice;
            this.courseservice = courseservice;
            this.gradeservice = gradeservice;
            this.depteservice = depteservice;
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