using System;
using App5_2.AdmissionFee.Conditions.Clock;
using App5_2.AdmissionFee.Conditions.ComplimentaryTickets;
using App5_2.AdmissionFee.Conditions.PersonType;
using App5_2.AdmissionFee.Conditions.VisitHistory;

namespace App5_2.AdmissionFee.Policy
{
    /// <summary>
    /// 入場料Policy…条件により入場料を決定する
    /// </summary>
    internal class Policy
    {
        /// <summary>
        /// 条件が入場者種別（Type)のみの場合での入場料取得
        /// </summary>
        /// <param name="personType">入場者種別（Type)</param>
        /// <returns>入場料</returns>
        public int GetFee(IPersonType personType)
        {
            return personType.Fee();
        }

        /// <summary>
        /// 条件が入場者種別（Type）、時刻の場合での入場料取得
        /// </summary>
        /// <param name="personType">入場者種別（Type)</param>
        /// <param name="clock">時刻</param>
        /// <returns>入場料</returns>
        internal int GetFee(IPersonType personType, IClock clock)
        {
            //夕刻の場合
            if (clock.IsEvening())
                return personType.EveningFee();

            return personType.Fee();
        }


        /// <summary>
        /// 条件が入場者種別（Type）、時刻、優待チケットの場合での入場料取得
        /// </summary>
        /// <param name="personType">入場者種別（Type)</param>
        /// <param name="clock">時刻</param>
        /// <param name="complimentaryTickets">優待チケット</param>
        /// <returns></returns>
        internal int GetFee(IPersonType personType, IClock clock, IComplimentaryTickets complimentaryTickets)
        {
            //優待チケットを有している場合は無料
            if (complimentaryTickets.HasTicket())
                return 0;

            return GetFee(personType, clock);
        }

        /// <summary>
        /// 条件が入場者種別（Type）、時刻、優待チケットの場合での入場料取得
        /// </summary>
        /// <param name="personType">入場者種別（Type)</param>
        /// <param name="clock">時刻</param>
        /// <param name="complimentaryTickets">優待チケット</param>
        /// <param name="visitHistory">訪問履歴</param>
        /// <returns></returns>
        internal int GetFee(IPersonType personType, IClock clock, IComplimentaryTickets complimentaryTickets, IVisitHistory visitHistory)
        {
            // 条件が入場者種別（Type）、時刻、優待チケットの場合での入場料取得
            var fee = GetFee(personType, clock, complimentaryTickets);
            
            //入場料が無料ではなく、昨日も訪問している場合は半額
            if (fee != 0 && visitHistory.IsVisitYesterday())
                fee = fee/2;

            return fee;
        }

    }
}
