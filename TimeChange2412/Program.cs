using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TimeChange2412
{
    class Program
    {
        public static void Main(string[] arg)
        {
            Regexcheck regex = new Regexcheck();
            Console.WriteLine("請輸入24小時制的時間(格式為00:00):");
            Console.WriteLine(regex.MilitaryTimeToRegularTime());
            Console.ReadKey();
            
        }
            
    }
}
