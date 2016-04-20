using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2_2.AdmissionFee.Conditions.Clock
{
    interface IClock
    {
        //夕刻かどうか
        bool IsEvening();
    }
}
