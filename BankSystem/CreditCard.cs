using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class CreditCard : Account
    {
        double Creditline;

        public CreditCard(double count, string id, string pwd, double money)
            : base(id, pwd, money)
        {
            this.Creditline = count;
        }

        override public bool WithdrawMoney(double money)//可以透支10000元
        {
            if ((this.getMoney() - money) > (-10000))
            {
                this.setMoney(this.getMoney() - money);
                return true;
            }

            return false;
        }
        public double getCredit()
        {
            return Creditline;
        }

        override public bool SaveMoney(double money)
        {
            if (money < 0) return false;  //卫语句

            base.SaveMoney(money);
            if (money > 1000 && this.getMoney() > 0)//当钱的余额大于0并且存入的钱数大于1000增加
            {                                       //信用额度
                this.Creditline++;
            }
            return true;
        }

    }


