namespace App4_2.AdmissionFee.Conditions.Clock
{
    internal class Clock : IClock
    {
        private readonly App4_2.Clock _clock;

        public Clock(App4_2.Clock clock)
        {
            _clock = clock;
        }

        /// <summary>
        /// ドメイン時計が夕刻かどうか
        /// </summary>
        /// <returns></returns>
        public bool IsEvening()
        {
            //16時以降は夕方とします
            var dt = _clock.GetTime();
            return dt.Hour >= 16;
        }
    }
}
