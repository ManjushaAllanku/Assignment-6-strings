using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctString
{
    class Program
    {
    

        public static int Alldistinct(string str)
        {
            int maxlength=0;
            int len = 0;
        
            Dictionary<char, int> D = new Dictionary<char, int>();
            for (int i = 0; i <= str.Length - 1; i++)
            {
      
            
                for (int j = i; j < str.Length - 1;j++)
                     {
                    if (!D.ContainsKey(str[j]))
                    {
                        D.Add(str[j], 1);
                    }
                    else
                    {

                        len = D.Count();
                        if (len > maxlength)
                            maxlength = len;
                        D.Clear();
                    }
                }
            }

            return maxlength;

        }



        static void Main(string[] args)
        {
            string s ="abcdaabbcdefg";
            Alldistinct(s);
            Console.WriteLine("the longest substring with distinct characters is " + Alldistinct(s));
            Console.ReadKey();
        }
    }
}
