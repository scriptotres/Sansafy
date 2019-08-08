using System;
using System.Collections.Generic;
using System.Text;

namespace Sansafy.Models
{
    public class ElmosContract: BaseClass
    {
        public Consultant Consultant { get; set; }
        public ContractType ContractType { get; set; }
    }
}
