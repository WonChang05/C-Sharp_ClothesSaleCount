using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesSaleCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag = "y";
            while (flag == "y")
            {
                //2.一件衣服399元，如果消費滿1500元，可以打79折
                //  顯示折扣後的金額或者提示消費者，還差多少錢就可以打折(四捨五入到整數)
                Console.WriteLine("買幾件衣服：");
                double Quantity = Convert.ToInt16(Console.ReadLine());
                double OPrice = Quantity * 399;
                double disPrice = Math.Round(OPrice * 0.79, 0);
                double diff = 1500 - OPrice;

                if (OPrice >= 1500)
                {
                    Console.WriteLine($"折扣後金額為{disPrice}元。");
                }
                else
                {
                    Console.WriteLine($"總金額為{OPrice}元，還差{diff}元可以打79折。");
                }
                Console.WriteLine("是否要繼續計算？y/n");
                if (Console.ReadLine() == "n")
                {
                    flag = "n";
                    Console.WriteLine("謝謝您的使用。");
                }
            }
        }
    }
}
