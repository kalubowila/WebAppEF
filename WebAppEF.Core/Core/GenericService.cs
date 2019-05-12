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
    public class GenericService : IGenericService
    {
        private readonly IGenericDataAccess _genericDataAccess;

        public GenericService()
        {
            _genericDataAccess = new GenericDataAccess();
        }
        public List<EnrollmentDateGroup> GetEnrollmentDateGroup()
        {
            return _genericDataAccess.GetEnrollmentDateGroup();
        }
    }
}
