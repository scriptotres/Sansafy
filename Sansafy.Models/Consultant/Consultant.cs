using System;
using System.Collections.Generic;
using System.Text;

namespace Sansafy.Models
{
    public class Consultant: Person
    {
        public ElmosContract ElmosContract { get; set; }
        public List<Account> Account { get; set; }

    }
}
