using App2_2.AdmissionFee.Conditions.Clock;
using App2_2.AdmissionFee.Conditions.PersonType;

namespace App2_2.AdmissionFee
{
    internal class AdmissionFeeFactiory
    {

        /// <summary>
        /// 条件クラス生成
        /// </summary>
        /// <returns></returns>
        private static Conditions.Conditions MakeConditions()
        {
            return new Conditions.Conditions();
        }

        /// <summary>
        /// ポリシークラス生成
        /// </summary>
        /// <returns></returns>
        private static Policy.Policy PolicyFactory()
        {
            return new Policy.Policy();
        }

        /// <summary>
        /// 入場料クラス生成
        /// </summary>
        /// <param name="personType">入場者タイプ</param>
        /// <returns></returns>
        public static AdmissionFee Make(PersonType personType)
        {
            var conditions = MakeConditions();

            //入場者タイプの条件作成
            conditions.PersonType = PersonTypeFactory.Make(personType);

            //入場料のポリシー作成
            var policy = PolicyFactory();

            return new AdmissionFee(conditions, policy);
        }

        /// <summary>
        /// 入場料クラス生成
        /// </summary>
        /// <param name="personType">入場者タイプ</param>
        /// <param name="clock">ドメイン時計</param>
        /// <returns></returns>
        internal static AdmissionFee Make(PersonType personType, Clock clock)
        {
            var conditions = MakeConditions();
            
            //入場者タイプの条件作成
            conditions.PersonType = PersonTypeFactory.Make(personType);

            //時刻の条件作成
            conditions.Clock = ClockFactory.Make(clock);

            //入場料のポリシー作成
            var policy = PolicyFactory();


            return new AdmissionFee(conditions, policy);
        }


    }
}
