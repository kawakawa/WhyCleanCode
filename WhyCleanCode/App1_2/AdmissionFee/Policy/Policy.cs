using App1_2.AdmissionFee.Conditons.PersonType;

namespace App1_2.AdmissionFee.Policy
{
    /// <summary>
    /// 入場料Policy…条件により入場料を決定する
    /// </summary>
    internal class Policy
    {
        /// <summary>
        /// 条件が入場者種別（Type)のみの場合での入場料取得
        /// </summary>
        /// <param name="personTypeCondition">入場者条件</param>
        /// <returns>入場料</returns>
        public int GetFee(IPersonType personTypeCondition)
        {
            return personTypeCondition.Fee();
        }
    }
}
