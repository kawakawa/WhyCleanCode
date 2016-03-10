﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    /// <summary>
    /// ドメイン時計
    /// </summary>
    internal class Clock
    {
        private readonly DateTime _dateTime;

        internal Clock()
        {
            _dateTime=DateTime.Now;
        }

        internal Clock(DateTime dateTime)
        {
            _dateTime = dateTime;
        }


        /// <summary>
        /// 時計が夕方帯なのか取得します（16時～）
        /// </summary>
        /// <returns></returns>
        internal bool IsEvening()
        {
            //16時以降は夕方とします
            return _dateTime.Hour >= 16;
        }
    }
}