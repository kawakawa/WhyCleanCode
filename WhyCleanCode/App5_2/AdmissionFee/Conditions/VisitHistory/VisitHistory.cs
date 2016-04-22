using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5_2.AdmissionFee.Conditions.VisitHistory
{
    internal class VisitHistory:IVisitHistory
    {
        /// <summary>
        /// 昨日も訪問していたか
        /// </summary>
        private bool _isVisitYesterday;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="visitHistory">訪問履歴</param>
        /// <param name="clock">時刻</param>
        public VisitHistory(App5_2.VisitHistory visitHistory, App5_2.Clock clock)
        {
            SetVisitYesterdayFlg(visitHistory, clock);
        }

        /// <summary>
        /// 昨日も訪問していたかフラグ設定
        /// </summary>
        /// <param name="visitHistory">訪問履歴</param>
        /// <param name="clock">時刻</param>
        private void SetVisitYesterdayFlg(App5_2.VisitHistory visitHistory, App5_2.Clock clock)
        {
            //昨日の時刻取得
            var yesterday = clock.GetYesterday();

            //昨日も訪問していたか
            _isVisitYesterday = visitHistory.IsVisit(yesterday);
        }

        /// <summary>
        /// 昨日も訪問しているか
        /// </summary>
        /// <returns></returns>
        public bool IsVisitYesterday()
        {
            return _isVisitYesterday;
        }
    }
}
