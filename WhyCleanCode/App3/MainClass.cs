using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    /// <summary>
    /// 追加条件（2）を実装
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// 入場者タイプごとの入場料を取得
        /// </summary>
        /// <param name="personType">入場者タイプ</param>
        /// <param name="clock">ドメイン時計</param>
        /// <returns>入場料</returns>
        public int AdmissionFee(PersonType personType, Clock clock)
        {

            switch (personType)
            {
                case PersonType.老人:
                    return 300;     //1日中同額料金

                case PersonType.大人:
                    return clock.IsEvening() ? 700 : 1000;//夕方料金：通常料金

                case PersonType.学生:
                    return clock.IsEvening() ? 400 : 700;//夕方料金：通常料金

                case PersonType.子供:
                    return clock.IsEvening() ? 200 : 500;//夕方料金：通常料金

                default:
                    //該当する入場者タイプが無い場合
                    throw new ArgumentOutOfRangeException(nameof(personType), personType, null);
            }

        }
    }
}
