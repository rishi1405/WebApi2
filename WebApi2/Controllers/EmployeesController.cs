using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace WebApi2.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBContext employeeDBContext=new EmployeeDBContext())
            {
                return employeeDBContext.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (EmployeeDBContext employeeDBContext = new EmployeeDBContext())
            {
                return employeeDBContext.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
