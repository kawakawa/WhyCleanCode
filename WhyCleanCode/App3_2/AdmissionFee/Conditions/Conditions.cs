using App3_2.AdmissionFee.Conditions.Clock;
using App3_2.AdmissionFee.Conditions.PersonType;

namespace App3_2.AdmissionFee.Conditions
{
    internal class Conditions
    {
        internal IPersonType PersonType { get; set; }
        internal IClock Clock { get; set; }
    }
}
