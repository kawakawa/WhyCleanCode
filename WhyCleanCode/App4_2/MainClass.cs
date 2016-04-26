using App4_2.AdmissionFee;

namespace App4_2
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
        /// <param name="complimentaryTickets">優待チケット情報</param>
        /// <returns>入場料</returns>
        public int AdmissionFee(PersonType personType, Clock clock,ComplimentaryTickets complimentaryTickets)
        {
            //入場料クラス生成
            var admissionFee = AdmissionFeeFactiory.Make(personType, clock, complimentaryTickets);

            //入場料取得
            return admissionFee.GetFee();
        }
    }
}
