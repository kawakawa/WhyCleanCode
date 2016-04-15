using App1_2.AdmissionFee.Conditons.PersonType;

namespace App1_2.AdmissionFee
{
    internal class AdmissionFeeFactiory
    {
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
