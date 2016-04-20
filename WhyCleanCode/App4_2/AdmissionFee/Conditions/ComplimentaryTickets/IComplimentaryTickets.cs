using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4_2.AdmissionFee.Conditions.ComplimentaryTickets
{
    interface IComplimentaryTickets
    {
        /// <summary>
        /// 優待チケットを保持しているかどうか
        /// </summary>
        /// <returns></returns>
        bool HasTicket();
    }
}
