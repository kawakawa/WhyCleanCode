using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    /// <summary>
    /// 優待チケット情報
    /// </summary>
    public class ComplimentaryTicket
    {
        /// <summary>
        /// 手持ちの残枚数
        /// </summary>
        private int _numberOfRemaining;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberOfTickets">手持ちのチケット枚数</param>
        public ComplimentaryTicket(int numberOfTickets)
        {
            _numberOfRemaining = numberOfTickets;
        }


        /// <summary>
        /// 優待チケットを持っているかどうか
        /// </summary>
        /// <returns></returns>
        public bool HasTicket()
        {
            if (_numberOfRemaining > 0)
                return true;
            
            return false;
        }


        /// <summary>
        /// 残枚数を減らす
        /// </summary>
        /// <param name="decreaseNumberOfTickets">減らすチケット枚数</param>
        public void DecreaseNumberOfRemainingTicket(int decreaseNumberOfTickets)
        {
            _numberOfRemaining = -decreaseNumberOfTickets;
        }




    }
}
