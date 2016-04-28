namespace App2_2.AdmissionFee.Policy
{
    public class PolicyFactory
    {
        /// <summary>
        /// 入場料のポリシークラス生成
        /// </summary>
        /// <returns></returns>
        public static Policy Create()
        {
            return new Policy();
        }
    }
}
