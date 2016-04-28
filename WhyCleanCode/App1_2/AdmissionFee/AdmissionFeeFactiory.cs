using App1_2.AdmissionFee.Conditions.PersonType;

namespace App1_2.AdmissionFee
{
    internal class AdmissionFeeFactiory
    {
        /// <summary>
        /// 入場料クラス生成
        /// </summary>
        /// <param name="personType">入場者タイプ</param>
        /// <returns></returns>
        internal static AdmissionFee Create(PersonType personType)
        {
            //入場の条件クラス作成
            var personTypeCondition = PersonTypeFactory.Create(personType);

            //入場料のポリシークラス生成
            var policy = Policy.PolicyFactory.Create();

            return new AdmissionFee(personTypeCondition, policy);
        }
    }
}
