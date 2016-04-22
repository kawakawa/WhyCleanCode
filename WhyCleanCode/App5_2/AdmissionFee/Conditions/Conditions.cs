using App5_2.AdmissionFee.Conditions.Clock;
using App5_2.AdmissionFee.Conditions.ComplimentaryTickets;
using App5_2.AdmissionFee.Conditions.PersonType;
using App5_2.AdmissionFee.Conditions.VisitHistory;

namespace App5_2.AdmissionFee.Conditions
{
    internal class Conditions
    {
        internal IPersonType PersonType { get; set; }
        internal IClock Clock { get; set; }
        internal IComplimentaryTickets ComplimentaryTickets { get; set; }
        internal IVisitHistory VisitHistory { get; set; }
    }
}
