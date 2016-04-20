using App4_2.AdmissionFee.Conditions.Clock;
using App4_2.AdmissionFee.Conditions.ComplimentaryTickets;
using App4_2.AdmissionFee.Conditions.PersonType;

namespace App4_2.AdmissionFee.Conditions
{
    internal class Conditions
    {
        internal IPersonType PersonType { get; set; }
        internal IClock Clock { get; set; }
        internal IComplimentaryTickets ComplimentaryTickets { get; set; }
    }
}
