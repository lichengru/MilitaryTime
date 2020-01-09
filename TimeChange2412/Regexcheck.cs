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
        string ip;
        int Iu;
        string[] clock;
        
        public void Timeset()
        {

            clock = ip.Split(':');
            Iu = Convert.ToInt32(clock[0]);
            switch (Iu)
            {
                case 00:
                    Console.WriteLine(Iu+":" + clock[1] + " a.m.");
                    break;
                case 12:
                    Console.WriteLine(Iu+":" + clock[1] + " p.m.");
                    break;
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
                    Console.WriteLine(Iu-12+":" + clock[1] + " p.m.");
                    break;                
                default:
                    Console.WriteLine(Iu + ":" + clock[1] + " a.m.");
                    break;
            }
          
        }
        public void Change()
        {
            ip = Console.ReadLine();
            Match match = Regex.Match(ip, pa);
            if (match.Success)
            {
                Timeset();
            }        
            else
            {
                Console.WriteLine("輸入錯誤，請重新輸入");
                Change();
            }
        }
    }
}
