using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    /// <summary>
    /// 追加条件（3）を実装
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// 入場者タイプごとの入場料を取得
        /// </summary>
        /// <param name="personType">入場者タイプ</param>
        /// <param name="clock">ドメイン時計</param>
        /// <param name="complimentaryTicket">優待チケット情報</param>
        /// <returns>入場料</returns>
        public int AdmissionFee(PersonType personType, Clock clock, ComplimentaryTicket complimentaryTicket)
        {

            //優待チケットがある場合
            if (complimentaryTicket.HasTicket())
            {
                //手持ちの優待チケットを1枚減らす
                complimentaryTicket.DecreaseNumberOfRemainingTicket(1);

                //入場料は無料
                return 0;
            }


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
