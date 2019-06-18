using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCSofTwoStrings
{
    // find the longest common sequence of two strings

    class Dynamicprogram
    {
        static void Main(string[] args)
        {
            string s1 = "AGGTAB";
            string S2 = "GXTXAYB";
            char[] X = s1.ToCharArray();
            char[] y = S2.ToCharArray();
            int l1 = X.Length ;
            int l2 = y.Length ;
            Console.WriteLine("longest common sequence length is " + LCS(X, y, l1, l2));
            Console.ReadKey();

        }

        public static int LCS(char[] ch1, char[] ch2, int length1, int length2)
        {
            if (length1 == 0 || length2 == 0)
                return 0;
            if (ch1[length1-1 ] == ch2[length2-1 ])
                return 1 + LCS(ch1, ch2, length1-1 , length2-1 );
            else
                return max(LCS(ch1, ch2, length1 , length2-1), LCS(ch1, ch2, length1-1, length2 ));
        }

        static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

    }
}