using System;
using System.Collections.Generic;
using System.Text;

namespace Sansafy.Models
{
    public class ContractType: BaseClass
    {
        public ElmosContract Contract { get; set; }
        public string Genre { get; set; }
    }
}
