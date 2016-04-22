using System;

namespace App5_2
{
    /// <summary>
    /// ドメイン時計
    /// </summary>
    public class Clock
    {
        private readonly DateTime _dateTime;

        public Clock()
        {
            _dateTime=DateTime.Now;
        }

        public Clock(DateTime dateTime)
        {
            _dateTime = dateTime;
        }

        public DateTime GetTime()
        {
            return _dateTime;
        }

        /// <summary>
        /// 昨日の時刻取得
        /// </summary>
        /// <returns></returns>
        public DateTime GetYesterday()
        {
            return _dateTime.AddDays(-1);
        }
    }
}
