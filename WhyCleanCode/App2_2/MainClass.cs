using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2_2.AdmissionFee;

namespace App2_2
{
    /// <summary>
    /// 追加条件（１）実装をリファクタリング
    /// （model層を意識した版）
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// 入場者タイプごとの入場料を取得
        /// </summary>
        /// <param name="personType">入場者タイプ</param>
        /// <param name="clock">ドメイン時計</param>
        /// <returns>入場料</returns>
        public int AdmissionFee(PersonType personType, Clock clock)
        {
            //入場料クラス生成
            var admissionFee = AdmissionFeeFactiory.Create(personType, clock);

            //入場料取得
            return admissionFee.GetFee();
        }
    }
}
