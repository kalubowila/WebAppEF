using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppEF.Core.InterfaceCore;
using WebAppEF.DataAccess.DataAccess;
using WebAppEF.DataAccess.InterfaceDataAccess;
using WebAppEF.Model.Entity;

namespace WebAppEF.Core.Core
{
    public class StudentService : IStudentService
    {
        private readonly IStudentDataAccess _studentDataAccess;
        public StudentService()
        {
            _studentDataAccess = new StudentDataAccess();
        }


        public List<Student> GetAllStudents()
        {
            return _studentDataAccess.GetAllStudents();
        }

        public Student GetStudentDetail(int? id)
        {
            return _studentDataAccess.GetStudentDetail(id);
        }

        public void UpdateStudent(Student student)
        {
            if (student.ID > 0)
            {
                _studentDataAccess.UpdateStudent(student);
            }
            else
            {
                _studentDataAccess.CreateStudent(student);
            }
        }

        public void DeleteStudent(int id)
        {
            _studentDataAccess.DeleteStudent(id);
        }
    }
}
