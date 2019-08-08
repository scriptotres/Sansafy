using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sansafy.Models
{
    public class Employee: Person
    {
        [Required]
        public EmployeeRole EmployeeRole { get; set; }

    }
}
