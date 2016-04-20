using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4_2.AdmissionFee.Conditions.ComplimentaryTickets
{
    internal class ComplimentaryTicketsFactory
    {
        /// <summary>
        /// 優待チケット条件クラス生成
        /// </summary>
        /// <param name="complimentaryTickets">優待チケット情報</param>
        /// <returns>優待チケット条件クラス</returns>
        internal static IComplimentaryTickets Make(App4_2.ComplimentaryTickets complimentaryTickets)
        {
            return new ComplimentaryTickets(complimentaryTickets);
        }
    }
}
