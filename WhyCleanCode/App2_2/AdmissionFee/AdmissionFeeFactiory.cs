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
            var conditions = CreateConditionsFactory(personType);

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
            var conditions = CreateConditionsFactory();

            //入場者タイプの条件作成
            conditions.PersonType = PersonTypeFactory.Create(personType);

            //時刻の条件作成
            conditions.Clock = ClockFactory.Create(clock);

            //入場料のポリシー作成
            var policy = PolicyFactory.Create();


            return new AdmissionFee(conditions, policy);
        }


        /// <summary>
        /// 条件クラス生成
        /// </summary>
        /// <returns></returns>
        private static Conditions.Conditions CreateConditionsFactory()
        {
            return new Conditions.Conditions();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="personType"></param>
        /// <returns></returns>
        private static Conditions.Conditions CreateConditionsFactory(PersonType personType)
        {
            var conditions = CreateConditionsFactory();

            //入場者タイプの条件作成
            conditions.PersonType = PersonTypeFactory.Create(personType);

            return conditions;
        }





    }
}
