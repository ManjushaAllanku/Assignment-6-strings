using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemAdjDup
{
    class Program
    {
        // REMOVE ALL ADJACENT DUPLICATES RECURSEVILY

        public static string RemoveDup(string str)
        {
            string s1 = "\0";
            int j=1;
            for(int i = 0; i <= str.Length - 1; i++)
            {
                if (str[i] == str[j])
                {
                    j++;
                }
                else
                {
                    s1 = s1 + str[j];
                    i = j;  ;
                    j++;
                }

            }

            return s1;


        }
      public   static void Main(string[] args)
        {
            string s = "bbzxxxy";
            Console.WriteLine("original string is " + s);

            Console.WriteLine("string after removing adjacent duplicates "+ RemoveDup(s));
            Console.ReadKey();

           
        }
    }
}
