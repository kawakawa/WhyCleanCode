﻿namespace App1_2.AdmissionFee.Conditons.PersonType
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
    }
}
