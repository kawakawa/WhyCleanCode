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
        public static AdmissionFee Make(PersonType personType)
        {
            //入場者タイプの条件作成
            var personTypeCondition = PersonTypeFactory.Make(personType);
            
            //入場料のポリシー作成
            var policy = new Policy.Policy();
            
            return new AdmissionFee(personTypeCondition,policy);
        }
    }
}
