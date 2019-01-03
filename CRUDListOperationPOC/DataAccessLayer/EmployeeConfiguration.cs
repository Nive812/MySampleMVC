using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;

namespace CRUDListOperationPOC.DataAccessLayer
{
    public class EmployeeConfiguration : DbConfiguration
    {
        public EmployeeConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}