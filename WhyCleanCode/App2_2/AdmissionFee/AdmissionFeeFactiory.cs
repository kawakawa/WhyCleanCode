using App2_2.AdmissionFee.Conditions.Clock;
using App2_2.AdmissionFee.Conditions.PersonType;
using App2_2.AdmissionFee.Policy;

namespace App2_2.AdmissionFee
{
    internal class AdmissionFeeFactiory
    {
        /// <summary>
        /// 入場料クラス生成
        /// </summary>
        /// <param name="personType">入場者タイプ</param>
        /// <returns></returns>
        public static AdmissionFee Create(PersonType personType)
        {
            //入場料の条件作成
            var conditions = Conditions.ConditionsFactory.Create(personType);

            //入場料のポリシー作成
            var policy = PolicyFactory.Create();

            return new AdmissionFee(conditions, policy);
        }


        /// <summary>
        /// 入場料クラス生成
        /// </summary>
        /// <param name="personType">入場者タイプ</param>
        /// <param name="clock">ドメイン時計</param>
        /// <returns></returns>
        internal static AdmissionFee Create(PersonType personType, Clock clock)
        {
            //入場料の条件作成
            var conditions = Conditions.ConditionsFactory.Create(personType, clock);

            //入場料のポリシー作成
            var policy = PolicyFactory.Create();

            return new AdmissionFee(conditions, policy);
        }







    }
}
