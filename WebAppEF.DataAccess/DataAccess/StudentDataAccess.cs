using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppEF.DataAccess.DB_Context;
using WebAppEF.DataAccess.InterfaceDataAccess;
using WebAppEF.Model.Entity;

namespace WebAppEF.DataAccess.DataAccess
{
    public class StudentDataAccess : IStudentDataAccess
    {
        public List<Student> GetAllStudents(string sortOrder, string searchString)
        {
            using (SchoolContext db = new SchoolContext())
            {
                var students = from s in db.Students
                               select s;

                if (!String.IsNullOrEmpty(searchString))
                {
                    students = students.Where(o => o.FirstMidName.Contains(searchString) || o.LastName.Contains(searchString));
                }

                switch (sortOrder)
                {
                    case "name_desc":
                        students = students.OrderByDescending(o => o.LastName);
                        break;
                    case "Date":
                        students = students.OrderBy(o => o.EnrollmentDate);
                        break;
                    case "date_desc":
                        students = students.OrderByDescending(o => o.EnrollmentDate);
                        break;
                    default:
                        students = students.OrderBy(o => o.LastName);
                        break;
                }

                return students.ToList();
            }
        }

        public Student GetStudentDetail(int? id)
        {
            using (SchoolContext db = new SchoolContext())
            {
                return db.Students.Find(id);
            }
        }

        public void UpdateStudent(Student student)
        {
            using (SchoolContext db = new SchoolContext())
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void CreateStudent(Student student)
        {
            using (SchoolContext db = new SchoolContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public void DeleteStudent(int id)
        {
            using (SchoolContext db = new SchoolContext())
            {
                Student studentToDelete = new Student() { ID = id };
                db.Entry(studentToDelete).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
