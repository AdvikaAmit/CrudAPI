using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAPI.Models
{
    public class Employee
    {
        public Employee(string name,string contact)
        {
            Name = name;
            Contact = contact;
        }
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}
