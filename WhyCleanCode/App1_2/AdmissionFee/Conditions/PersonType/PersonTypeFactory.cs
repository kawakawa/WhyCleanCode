using System;

namespace App1_2.AdmissionFee.Conditions.PersonType
{
    /// <summary>
    /// 入場者種別（Type)の状態Object作成
    /// </summary>
    internal class PersonTypeFactory
    {
        public static IPersonType Make(App1_2.PersonType personType)
        {
            switch (personType)
            {
                case App1_2.PersonType.大人:
                    return new 大人();
                case App1_2.PersonType.学生:
                    return new 学生();
                case App1_2.PersonType.子供:
                    return new 子供();
                default:
                    //該当する入場者タイプが無い場合
                    throw new ArgumentOutOfRangeException(nameof(personType), personType, null);
            }
        }
    }
}
