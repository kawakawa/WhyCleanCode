using App2_2.AdmissionFee.Conditions.Clock;
using App2_2.AdmissionFee.Conditions.PersonType;

namespace App2_2.AdmissionFee.Conditions
{
    public class Conditions
    {
        /// <summary>
        /// 入場者タイプの条件
        /// </summary>
        private IPersonType _personTypeCondition;


        /// <summary>
        /// ドメイン時計の条件
        /// </summary>
        private IClock _clockCondition;


        /// <summary>
        /// 入場者タイプ条件の登録
        /// </summary>
        /// <param name="personTypeCondition">入場者タイプ条件</param>
        public void PersonTypeConditionRegist(IPersonType personTypeCondition)
        {
            _personTypeCondition = personTypeCondition;
        }

        /// <summary>
        /// 入場者タイプ条件が登録されているか
        /// </summary>
        /// <returns></returns>
        public bool HasPersonTypeCondition()
        {
            return _personTypeCondition != null;
        }

        /// <summary>
        /// 入場者タイプの取得
        /// </summary>
        /// <returns></returns>
        public IPersonType PersonTypeCondition()
        {
            return _personTypeCondition;
        }



        public void ClockConditionRegist(IClock clockCondition)
        {
            _clockCondition = clockCondition;
        }

        public bool HasClockTypeCondition()
        {
            return _clockCondition != null;
        }

        public IClock ClockCondition()
        {
            return _clockCondition;
        }



    }
}
