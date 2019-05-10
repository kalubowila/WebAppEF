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
        public List<Student> GetAllStudents()
        {
            using (SchoolContext db = new SchoolContext())
            {
                return db.Students.ToList();
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
                db.Students.Remove(db.Students.Find(id));
                db.SaveChanges();
            }
        }
    }
}
