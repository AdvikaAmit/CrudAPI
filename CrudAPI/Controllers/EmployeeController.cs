using CrudAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAPI.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public static List<Employee> empdata = new List<Employee>();

        [HttpGet]
        public List<Employee> GetEmployeeList()
        {
            return empdata;
        }

        [HttpGet("{id}")]
        public Employee GetEmployeeList(int id)
        {
            var emp = empdata[id];
            return emp;
        }

        [HttpPost]
        public List<Employee> Add(Employee emp)
        {
            empdata.Add(new Employee(emp.Name,emp.Contact));           
            return empdata;
        }

        [HttpPut("{id}")]
        public List<Employee> Update(int id,Employee emp)
        {
           empdata[id] = emp;          
           return empdata;
        }

        [HttpDelete("{id}")]
        public List<Employee> Delete(int id)
        {
            var emp = empdata[id];
            empdata.Remove(emp);
            return empdata;
        }
    }
}
