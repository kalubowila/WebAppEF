using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppEF.DataAccess.DB_Context;
using WebAppEF.DataAccess.InterfaceDataAccess;
using WebAppEF.Model.Entity;

namespace WebAppEF.DataAccess.DataAccess
{
    public class GenericDataAccess : IGenericDataAccess
    {
        public List<EnrollmentDateGroup> GetEnrollmentDateGroup()
        {
            using (SchoolContext db = new SchoolContext())
            {
                IQueryable<EnrollmentDateGroup> data = from student in db.Students
                                                       group student by student.EnrollmentDate into dateGroup
                                                       select new EnrollmentDateGroup()
                                                       {
                                                           EnrollmentDate = dateGroup.Key,
                                                           StudentCount = dateGroup.Count()
                                                       };
                return data.ToList();
            }
        }
    }
}
