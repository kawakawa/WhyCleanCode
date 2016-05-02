using System;

namespace App2_2.AdmissionFee
{
    /// <summary>
    /// 入場料
    /// </summary>
    internal class AdmissionFee
    {


        /// <summary>
        /// 条件クラス
        /// </summary>
        private readonly Conditions.Conditions _conditions;
        

        /// <summary>
        /// 入場料のポリシー
        /// </summary>
        private readonly Policy.Policy _policy;



        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="conditions">条件クラス</param>
        /// <param name="policy">入場料ポリシー</param>
        public AdmissionFee(Conditions.Conditions conditions,Policy.Policy policy)
        {
            _conditions = conditions;
            _policy = policy;
        }



        /// <summary>
        /// 条件とポリシーを使って入場料決定
        /// </summary>
        /// <returns>入場料</returns>
        public int GetFee()
        {
            //入場者種別（Type)、時間
            if (_conditions.HasPersonTypeCondition() && _conditions.HasClockTypeCondition())
                return _policy.GetFee(_conditions.PersonTypeCondition(), _conditions.ClockCondition());

            //入場者種別（Type)
            if (_conditions.HasPersonTypeCondition())
                return _policy.GetFee(_conditions.PersonTypeCondition());


            //該当する条件がなかった
            throw new ArgumentOutOfRangeException(nameof(_conditions), _conditions, null);
        }
    }
}
