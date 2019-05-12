using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppEF.DataAccess.DataAccess
{
    public class DBAccessConfiguration : DbConfiguration
    {
        public DBAccessConfiguration()
        {
            //Retry Policy
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());

            DbInterception.Add(new DBInterceptorTransientErrors());
            DbInterception.Add(new DBInterceptorLogging());
        }
    }
}
