using App1_2.AdmissionFee.Conditions.PersonType;

namespace App1_2.AdmissionFee
{
    /// <summary>
    /// 入場料
    /// </summary>
    internal class AdmissionFee
    {
        /// <summary>
        /// 入場者種別（type）ごとの条件
        /// </summary>
        private readonly IPersonType _personTypeCondition;


        /// <summary>
        /// 入場料のポリシー
        /// </summary>
        private readonly Policy.Policy _policy;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="personTypePersonTypeCondition">入場者種別（type）ごとの条件</param>
        /// <param name="policy">入場料ポリシー</param>
        public AdmissionFee(IPersonType personTypePersonTypeCondition, Policy.Policy policy)
        {
            _personTypeCondition = personTypePersonTypeCondition;
            _policy = policy;
        }


        /// <summary>
        /// 条件とポリシーを使って入場料決定
        /// </summary>
        /// <returns>入場料</returns>
        public int GetFee()
        {
            return _policy.GetFee(_personTypeCondition);
        }
    }
}
