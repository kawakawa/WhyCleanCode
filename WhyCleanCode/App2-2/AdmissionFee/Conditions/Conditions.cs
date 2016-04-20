using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2_2.AdmissionFee.Conditions.Clock;
using App2_2.AdmissionFee.Conditions.PersonType;

namespace App2_2.AdmissionFee.Conditions
{
    internal class Conditions
    {
        internal IPersonType PersonType { get; set; }
        internal IClock Clock { get; set; }
    }
}
