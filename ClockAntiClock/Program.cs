using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAntiClock
{
    class Program
    {
        public static Boolean checkClockAnti(String st1, String st2)
        {
            if (st1.Length == 0 || st2.Length == 0)

                return false;
            if (st1.Length != st2.Length)
                return false;
            string clock = " ";
            String Anticlock = " ";
            int len = st2.Length;
            clock = clock + st2.Substring(2) + st2.Substring(0, 2);
            Anticlock = Anticlock + st2.Substring(len - 2, len - (len - 2))+st2.Substring(0,len-2);

            return (st1.Equals(clock) || st1.Equals(Anticlock));
        }
        static void Main(string[] args)
        {
            String s1 = "amazon";
            String s2 = "azonam";
            Console.WriteLine(checkClockAnti(s1, s2) ? "yes" : "no");
            Console.ReadKey();
        }
    }
}
