using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    /// <summary>
    /// 追加条件（4）を実装
    /// (トランザクションスクリプト版）
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// 入場者タイプごとの入場料を取得
        /// </summary>
        /// <param name="personType">入場者タイプ</param>
        /// <param name="clock">ドメイン時計</param>
        /// <param name="complimentaryTicket">優待チケット情報</param>
        /// <param name="visitInfo">訪問情報</param>
        /// <returns>入場料</returns>
        public int AdmissionFee(PersonType personType, Clock clock, ComplimentaryTicket complimentaryTicket,VisitInfo visitInfo)
        {

            //優待チケットがある場合
            if (complimentaryTicket.HasTicket())
            {
                //手持ちの優待チケットを1枚減らす
                complimentaryTicket.DecreaseNumberOfRemainingTicket(1);

                //入場料は無料
                return 0;
            }

            //入場料
            var admissionFee = 0;

            switch (personType)
            {
                case PersonType.老人:
                    admissionFee=300;     //1日中同額料金
                    break;

                case PersonType.大人:
                    admissionFee = clock.IsEvening() ? 700 : 1000;//夕方料金：通常料金
                    break;

                case PersonType.学生:
                    admissionFee = clock.IsEvening() ? 400 : 700;//夕方料金：通常料金
                    break;

                case PersonType.子供:
                    admissionFee = clock.IsEvening() ? 200 : 500;//夕方料金：通常料金
                    break;

                default:
                    //該当する入場者タイプが無い場合
                    throw new ArgumentOutOfRangeException(nameof(personType), personType, null);
            }


            //昨日の日付取得
            var yesterDay = clock.GetDay(-1);

            //昨日も入場している場合
            if (visitInfo.IsVisit(yesterDay))
                return admissionFee/2;  //入場料半額

            return admissionFee;

        }
    }
}
