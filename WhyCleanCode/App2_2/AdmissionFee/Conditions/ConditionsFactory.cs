using System;

namespace App2_2.AdmissionFee.Conditions
{
    public class ConditionsFactory
    {

        /// <summary>
        /// 条件リストに入場者タイプの条件追加
        /// </summary>
        /// <param name="list">条件リスト</param>
        /// <param name="personType">入場者タイプ</param>
        private static void SetPersonTypeCondition(Conditions list, App2_2.PersonType personType)
        {
            list.PersonTypeConditionRegist(PersonType.PersonTypeFactory.Create(personType));
        }

        /// <summary>
        /// 条件リストにドメイン時計の条件追加
        /// </summary>
        /// <param name="list">条件リスト</param>
        /// <param name="clock">ドメイン時計</param>
        private static void SetClockCondition(Conditions list, App2_2.Clock clock)
        {
            list.ClockConditionRegist( Clock.ClockFactory.Create(clock) );
        }

        /// <summary>
        /// 条件リストのクラス生成
        /// </summary>
        /// <returns>条件リストクラス</returns>
        private static Conditions Create()
        {
            return new Conditions();
        }

        /// <summary>
        /// 条件リストのクラス生成
        /// </summary>
        /// <param name="personType">入場者タイプ成</param>
        /// <returns>条件リストクラス</returns>
        public static Conditions Create(App2_2.PersonType personType)
        {
            var conditionsList = Create();

            //入場者タイプの条件追加
            SetPersonTypeCondition(conditionsList, personType);
            
            return conditionsList;
        }

        /// <summary>
        /// 条件リストのクラス生成
        /// </summary>
        /// <param name="personType">入場者タイプ</param>
        /// <param name="clock">ドメイン時計</param>
        /// <returns></returns>
        public static Conditions Create(App2_2.PersonType personType, App2_2.Clock clock)
        {
            var conditionsList = Create();

            //入場者タイプの条件追加
            SetPersonTypeCondition(conditionsList, personType);
            //ドメイン時計の条件追加
            SetClockCondition(conditionsList, clock);

            return conditionsList;
        }


    }
}
