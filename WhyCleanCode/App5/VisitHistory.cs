using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    /// <summary>
    /// 訪問履歴
    /// </summary>
    public class VisitHistory
    {
        /// <summary>
        /// 訪問時刻の履歴
        /// </summary>
        private List<DateTime> _visitDateTimes=new List<DateTime>();

        /// <summary>
        /// 訪問時刻の履歴
        /// </summary>
        /// <param name="date"></param>
        public void Visit(DateTime date)
        {
            _visitDateTimes.Add(date);
        }


        /// <summary>
        /// 指定日に訪問しているか判定
        /// </summary>
        /// <param name="targetDay">指定日</param>
        /// <returns>True=訪問している/False=訪問していない</returns>
        public bool IsVisit(DateTime targetDay)
        {
            var query = _visitDateTimes.Any(n => n.ToString("yyyyMMdd") == targetDay.ToString("yyyyMMdd"));
            return query;
        }

    }
}
