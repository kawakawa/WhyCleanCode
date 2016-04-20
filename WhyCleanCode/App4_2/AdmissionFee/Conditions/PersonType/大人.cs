namespace App4_2.AdmissionFee.Conditions.PersonType
{
    /// <summary>
    /// 入場者種別（Type)：大人
    /// </summary>
    internal class 大人:IPersonType
    {
        /// <summary>
        /// 大人の入場料取得
        /// </summary>
        /// <returns>入場料</returns>
        public int Fee()
       {
           return 1000;
       }

        /// <summary>
        /// 大人の入場料取得（夕刻時）
        /// </summary>
        /// <returns>入場料</returns>
        public int EveningFee()
        {
            return 700;
        }

    }
}
