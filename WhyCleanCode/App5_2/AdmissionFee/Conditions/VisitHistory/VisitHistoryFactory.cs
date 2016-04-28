using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5_2.AdmissionFee.Conditions.VisitHistory
{
    internal class VisitHistoryFactory
    {


        /// <summary>
        /// 訪問履歴条件を作成
        /// </summary>
        /// <param name="visitHistory">訪問履歴</param>
        /// <param name="clock">時刻</param>
        /// <returns>訪問履歴条件クラス</returns>
        internal static IVisitHistory Create(App5_2.VisitHistory visitHistory, App5_2.Clock clock)
        {
            return new VisitHistory(visitHistory,clock);
        }
    }
}
