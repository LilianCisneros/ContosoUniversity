using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.SqlServer;
using System.Data.Entity.Infrastructure.Interception;

namespace ContosoUniversity.DAL
{
    public class SchoolConfiguration : System.Data.Entity.DbConfiguration
    {
        public SchoolConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
            //DbInterception.Add(new SchoolInterceptorTransientErrors());
            DbInterception.Add(new SchoolInterceptorLogging());
        }
    }
}