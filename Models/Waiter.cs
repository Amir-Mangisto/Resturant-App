using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantUsingMvcEtLts.Models
{
    public class Waiter
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birth { get; set; }
        public int WorkingHours { get; set; }
    }
}