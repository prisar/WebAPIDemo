using EmployeeDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities entites = new EmployeeDBEntities())
            {
                return entites.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (EmployeeDBEntities entites = new EmployeeDBEntities())
            {
                return entites.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
