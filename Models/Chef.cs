using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantUsingMvcEtLts.Models
{
    public class Chef
    {
        public Chef(int id, string fullName, int age, string email, int salary)
        {
            Id = id;
            FullName = fullName;
            Age = age;
            Email = email;
            Salary = salary;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }

    }
}