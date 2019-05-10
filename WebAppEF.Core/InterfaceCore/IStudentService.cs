using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppEF.Model.Entity;

namespace WebAppEF.Core.InterfaceCore
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudentDetail(int? id);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}
