namespace App3_2.AdmissionFee.Conditions.PersonType
{
    /// <summary>
    /// 入場者種別（Type)：老人
    /// </summary>
    internal class 老人 : IPersonType
    {
        /// <summary>
        /// 老人の入場料取得
        /// </summary>
        /// <returns>入場料</returns>
        public int Fee()
        {
            return 300;
        }

        /// <summary>
        /// 老人の入場料取得（夕刻時）
        /// </summary>
        /// <returns>入場料</returns>
        public int EveningFee()
        {
            return 300;
        }
    }
}
