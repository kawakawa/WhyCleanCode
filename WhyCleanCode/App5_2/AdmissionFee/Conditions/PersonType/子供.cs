namespace App5_2.AdmissionFee.Conditions.PersonType
{
    /// <summary>
    /// 入場者種別（Type)：子供
    /// </summary>
    internal class 子供:IPersonType
    {
        /// <summary>
        /// 子供の入場料取得
        /// </summary>
        /// <returns>入場料</returns>
        public int Fee()
        {
            return 500;
        }

        /// <summary>
        /// 子供の入場料取得（夕刻時）
        /// </summary>
        /// <returns>入場料</returns>
        public int EveningFee()
        {
            return 200;
        }
    }
}
