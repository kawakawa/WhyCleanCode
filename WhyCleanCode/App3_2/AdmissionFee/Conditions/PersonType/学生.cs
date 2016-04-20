namespace App3_2.AdmissionFee.Conditions.PersonType
{
    /// <summary>
    /// 入場者種別（Type)：学生
    /// </summary>
    internal class 学生:IPersonType
    {
        /// <summary>
        /// 学生の入場料取得
        /// </summary>
        /// <returns>入場料</returns>
        public int Fee()
        {
            return 700;
        }

        /// <summary>
        /// 学生の入場料取得（夕刻時）
        /// </summary>
        /// <returns>入場料</returns>
        public int EveningFee()
        {
            return 400;
        }
    }
}
