using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgularJS.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string MaleOrFemale { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }
        public string Address { get; set; }
    }
}