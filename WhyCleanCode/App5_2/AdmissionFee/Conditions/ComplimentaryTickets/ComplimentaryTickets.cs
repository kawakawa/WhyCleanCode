using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5_2.AdmissionFee.Conditions.ComplimentaryTickets
{
    internal class ComplimentaryTickets : IComplimentaryTickets
    {
        /// <summary>
        /// 優待チケットを有しているかどうか
        /// </summary>
        private bool _hasTicket;

        public ComplimentaryTickets(App5_2.ComplimentaryTickets complimentaryTickets)
        {
            //優待チケット残り枚数取得
            var numberOfRemaining = complimentaryTickets.GetNumberOfRemaining();

            //優待チケットを有している
            if (numberOfRemaining > 0)
                _hasTicket = true;
            else
                _hasTicket = false;
        }


        /// <summary>
        /// チケットを保持しているかどうか
        /// </summary>
        /// <returns></returns>
        public bool HasTicket()
        {
            return _hasTicket;
        }
    }
}
