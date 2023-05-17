using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

           
            double rate = 23450;

            Console.Write("Nhập giá trị USD: ");
            double usdValue = Convert.ToDouble(Console.ReadLine());

            double vndValue = usdValue * rate;
            Console.WriteLine("Giá trị tương ứng của {0} USD là {1} VND", usdValue, vndValue);

            Console.ReadLine();
        }
    }
}
