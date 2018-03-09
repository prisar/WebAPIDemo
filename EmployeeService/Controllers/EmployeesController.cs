using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        [Authorize]
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities entites = new EmployeeDBEntities())
            {
                return entites.Employees.ToList();
            }
        }
    }
}
