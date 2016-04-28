using App1_2.AdmissionFee;

namespace App1_2
{
    /// <summary>
    /// 基本情報を実装
    /// （model層を意識した版）
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// 入場者タイプごとの入場料を取得
        /// </summary>
        /// <param name="personType">入場者タイプ</param>
        /// <returns>入場料</returns>
        public int AdmissionFee(PersonType personType)
        {
            //入場料クラス生成
            var admissionFee = AdmissionFeeFactiory.Create(personType);

            //入場料取得
            return admissionFee.GetFee();
        }

    }
}
