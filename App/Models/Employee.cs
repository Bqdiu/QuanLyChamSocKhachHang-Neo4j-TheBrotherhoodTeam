using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DoB { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CitizenId { get; set; }
        public string EmployeeRole { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DisplayValue => $"{Id}-{Name}";
    }
}
