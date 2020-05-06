using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("월 입력 : ");
            string month =Console.ReadLine();
            string num =month.Replace("월", "");
            int res = int.Parse(num);

            switch (res)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;

                default:
                    Console.WriteLine("월을 잘못 입력하셨습니다.");
                    break;
            }



        }
    }
}
