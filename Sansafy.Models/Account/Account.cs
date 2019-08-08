using System;
using System.Collections.Generic;
using System.Text;

namespace Sansafy.Models
{
    public class Account: BaseClass
    {
        public string NameCompany { get; set; }
        public List<Consultant> Consultants { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
