using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TimeChange2412
{
    public class Regexcheck
    {

        string pa = @"^(20|21|22|23|[0-1]\d)\:[0-5]\d$";
        string input;
        int hour;
        string[] clock;

        public string Timeset()
        {

            clock = input.Split(':');
            hour = Convert.ToInt32(clock[0]);
            switch (hour)
            {
                case 00:
                    return  ("12:" + clock[1] + " a.m.");
                case 12:
                    return (hour + ":" + clock[1] + " p.m.");
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                    return (hour - 12 + ":" + clock[1] + " p.m.");
                default:
                    return (hour + ":" + clock[1] + " a.m.");
            }

        }
        public string MilitaryTimeToRegularTime()
        {
            input = Console.ReadLine();
            Match match = Regex.Match(input, pa);
            if (match.Success)
            {
                return Timeset();
            }
            else
            {
                Console.WriteLine("輸入錯誤，請重新輸入");
                return MilitaryTimeToRegularTime();
            }
        }
    }
}
