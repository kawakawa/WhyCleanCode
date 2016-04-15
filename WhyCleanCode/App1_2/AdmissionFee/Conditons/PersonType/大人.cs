﻿namespace App1_2.AdmissionFee.Conditons.PersonType
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
    }
}
