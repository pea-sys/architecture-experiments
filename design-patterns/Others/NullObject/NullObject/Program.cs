using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    /// <summary>
    /// NullObjectパターン・・・Null Objectパターンはクライアントコードを簡素化し、誤りを生じにくくするのに役立ちます
    /// [参考URL]
    /// https://www.hyuki.com/dp/dpinfo.html#NullObject
    /// https://codezine.jp/article/detail/4721
    /// 
    /// C# 8.0以上ならnull許容型で良さそう
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountController ac = new AccountController();
            string userName = args[0];
            string pin = args[1];
            Order order = new Order();

            for (int i = 2; i < args.Length; i++)
            {
                order.Amount += Convert.ToDecimal(args[i]);
            }

            var account = ac.GetAccount(pin);

            if (account is NullAccount)
            {
                Console.WriteLine("Invalid Account");
            }
            else
            {
                var gProfile = GoldMembershipController.GetProfile(account);

                order.Amount -= gProfile.GetDiscount(order.Amount);

                if (!gProfile.IsShippingFree)
                {
                    order.Amount += order.ShippingCharges;
                }

                Console.WriteLine(string.Format("Total Amount: {0}", order.Amount));
                Console.ReadLine();
            }
        }
    }
}
