using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppEF.Model.Entity;

namespace WebAppEF.DataAccess.InterfaceDataAccess
{
    public interface IGenericDataAccess
    {
        List<EnrollmentDateGroup> GetEnrollmentDateGroup();
    }
}
