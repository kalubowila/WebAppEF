using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using WebAppEF.Core.Core;
using WebAppEF.Core.InterfaceCore;
using WebAppEF.Model.Entity;

namespace WebAppEF.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController()
        {
            _studentService = new StudentService();
        }

        // GET: Student
        public ActionResult Index()
        {
            List<Student> studentList = _studentService.GetAllStudents();
            return View(studentList);
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = _studentService.GetStudentDetail(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LastName,FirstMidName,EnrollmentDate")] Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.UpdateStudent(student);
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = _studentService.GetStudentDetail(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LastName,FirstMidName,EnrollmentDate")] Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.UpdateStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = _studentService.GetStudentDetail(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _studentService.DeleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}
