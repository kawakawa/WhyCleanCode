using System;

namespace App3_2
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

    }
}
