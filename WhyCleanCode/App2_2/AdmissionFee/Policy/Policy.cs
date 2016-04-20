using App2_2.AdmissionFee.Conditions.Clock;
using App2_2.AdmissionFee.Conditions.PersonType;

namespace App2_2.AdmissionFee.Policy
{
    /// <summary>
    /// 入場料Policy…条件により入場料を決定する
    /// </summary>
    internal class Policy
    {
        /// <summary>
        /// 条件が入場者種別（Type)のみの場合での入場料取得
        /// </summary>
        /// <param name="personTypeCondition">入場者種別（Type)</param>
        /// <returns>入場料</returns>
        public int GetFee(IPersonType personTypeCondition)
        {
            return personTypeCondition.Fee();
        }

        /// <summary>
        /// 条件が入場者種別（Type）、時刻の場合での入場料取得
        /// </summary>
        /// <param name="personTypeCondition">入場者種別（Type)</param>
        /// <param name="clock">時刻</param>
        /// <returns>入場料</returns>
        internal int GetFee(IPersonType personTypeCondition, IClock clock)
        {
            //夕刻の場合
            if (clock.IsEvening())
                return personTypeCondition.EveningFee();

            return personTypeCondition.Fee();
        }
    }
}
