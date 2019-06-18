using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMPstringmatch
{
    class Program
    {
      

        public static int[] LPS(string pat ,int[] lps)
        {
            int l = pat.Length - 1;
            int i = 1;
            int j = 0;
            lps[0] = 0;
            while (i < l)
            {
                if (pat[i] == pat[j])
                {
                    j++;
                    lps[i] = j;
                    i++;
                }
                else
                {
                    if (j != 0)
                    {
                        lps[i] = lps[j - 1];
                    }
                    else
                        lps[i] = j;
                    i++;
                }


            }
            return lps;
        }

        public static void  Patsearch(string pat, string text)
        {
            int pl = pat.Length - 1;
            int textl = text.Length - 1;
            int []lps=new int[pl];
            int i = 0; int j = 0;
            while (i < textl)
            {
               if(pat[j] == text[i])
                {
                    j++;
                    i++;
                    
                }
                if (j == textl)
                {
                    Console.WriteLine("pattern found at index " + (i - j));
                    j = lps[j - 1];
                }
                else if (i< textl && pat[j]!=text[i])
                {
                    if(j!=0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }

            }


        }
       public  static void Main(string[] args)
        {
            String p = "ababcabab";
            int[] a = new int[p.Length - 1];

            Console.WriteLine(LPS(p,a));
            Console.ReadKey();

        }
    }
}
