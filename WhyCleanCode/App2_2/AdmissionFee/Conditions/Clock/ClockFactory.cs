namespace App2_2.AdmissionFee.Conditions.Clock
{
    internal class ClockFactory
    {
        /// <summary>
        /// 時刻条件クラスを生成
        /// </summary>
        /// <param name="clock">ドメイン時計</param>
        /// <returns>時刻条件クラス</returns>
        public static IClock Make(App2_2.Clock clock)
        {
            return new Clock(clock);
        }
    }
}
