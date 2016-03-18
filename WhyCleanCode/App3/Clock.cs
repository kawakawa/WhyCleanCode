using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    /// <summary>
    /// ドメイン時計
    /// </summary>
    public class Clock
    {
        private readonly DateTime _dateTime;

        public Clock()
        {
            _dateTime = DateTime.Now;
        }

        public Clock(DateTime dateTime)
        {
            _dateTime = dateTime;
        }


        /// <summary>
        /// 時計が夕方帯なのか取得します（16時～）
        /// </summary>
        /// <returns></returns>
        public bool IsEvening()
        {
            //16時以降は夕方とします
            return _dateTime.Hour >= 16;
        }
    }
}
