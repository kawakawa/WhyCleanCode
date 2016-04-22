using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5_2.AdmissionFee.Conditions.VisitHistory
{
    interface IVisitHistory
    {
        /// <summary>
        /// 昨日も訪問しているか
        /// </summary>
        /// <returns></returns>
        bool IsVisitYesterday();
    }
}
