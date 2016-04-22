using App5_2.AdmissionFee;

namespace App5_2
{
    /// <summary>
    /// 追加条件（１）実装をリファクタリング
    /// （HowよりWhatに意図を意識した版）
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// 入場者タイプごとの入場料を取得
        /// </summary>
        /// <param name="personType">入場者タイプ</param>
        /// <param name="clock">ドメイン時計</param>
        /// <param name="complimentaryTickets">優待チケット情報</param>
        /// <param name="visitHistory">訪園履歴</param>
        /// <returns>入場料</returns>
        public int AdmissionFee(PersonType personType, Clock clock,ComplimentaryTickets complimentaryTickets,VisitHistory visitHistory)
        {
            //入場料クラス生成
            var admissionFee = AdmissionFeeFactiory.Make(personType, clock, complimentaryTickets,visitHistory);

            //入場料取得
            return admissionFee.GetFee();
        }
    }
}
