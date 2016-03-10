using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class MainClass
    {
        /// <summary>
        /// 入場者タイプごとの入場料を取得
        /// </summary>
        /// <param name="personType">入場者タイプ</param>
        /// <returns>入場料</returns>
        public int AdmissionFee(PersonType personType)
        {
            switch (personType)
            {
                case PersonType.大人:
                    return 1000;
                case PersonType.学生:
                    return 700;
                case PersonType.子供:
                    return 500;
                default:
                    //該当する入場者タイプが無い場合
                    throw new ArgumentOutOfRangeException(nameof(personType), personType, null);
            }
        }
    }
}
