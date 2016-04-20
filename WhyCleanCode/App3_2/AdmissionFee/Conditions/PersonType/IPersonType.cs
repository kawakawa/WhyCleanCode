namespace App3_2.AdmissionFee.Conditions.PersonType
{
    /// <summary>
    /// 入場者種別（Type)の状態用インターフェース
    /// </summary>
    internal interface IPersonType
    {
        //通常時の入場料
        int Fee();

        //夕刻時の入場料
        int EveningFee();
    }

    
}
