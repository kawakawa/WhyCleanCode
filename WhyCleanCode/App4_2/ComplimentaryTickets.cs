using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4_2
{
    /// <summary>
    /// 優待チケット情報
    /// </summary>
    public class ComplimentaryTickets
    {

        /// <summary>
        /// 手持ちの残枚数
        /// </summary>
        private int _numberOfRemaining;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberOfTickets">手持ちのチケット枚数</param>
        public ComplimentaryTickets(int numberOfTickets)
        {
            _numberOfRemaining = numberOfTickets;
        }

        /// <summary>
        /// 残り枚数を取得
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfRemaining()
        {
            return _numberOfRemaining;
        }
    }
}
