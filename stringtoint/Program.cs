using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringtoint
{
    class Program
    {
        public static int Atoi(string str)
        {
            int res=0;
            int sign = 0;
            if (str.Length == 0)
                return -1;
            for (int i = 0; i <= str.Length; i++)
            {
                if (str[0] == '-')
                {
                     sign = -1;
                    i++;
                    res = res * 10 + str[i];
                }
                return sign * res;
            }
            return 1;

        }

        static void Main(string[] args)
        {
            string s = "-8765";
            Console.WriteLine("string is converted into integer  " + s);
            Console.ReadKey();
        }
    }
}
