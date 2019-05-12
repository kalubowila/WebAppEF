using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppEF.Model.Entity;

namespace WebAppEF.DataAccess.InterfaceDataAccess
{
    public interface IStudentDataAccess
    {
        List<Student> GetAllStudents(string sortOrder, string searchString);
        Student GetStudentDetail(int? id);
        void CreateStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}
