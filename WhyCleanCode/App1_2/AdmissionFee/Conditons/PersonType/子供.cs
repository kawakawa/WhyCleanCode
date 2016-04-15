﻿namespace App1_2.AdmissionFee.Conditons.PersonType
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
    }
}
