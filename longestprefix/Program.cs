using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longestprefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr = { " apple", "ape", "april" };
           

            Console.WriteLine(Sortarr(sarr));
            Console.ReadKey();
        }

        public static string Commprefix(string s1, string s2)
        {
            int n1 = s1.Length - 1;
            int n2 = s2.Length - 1;
            string s = " ";
            for (int i=0, j=0;i <n1 && j< n2; i++, j++)
            {
                if (s1[i] != s2[j])
                    break;
                else
                    s = s + s1[i];
            }
            return s;

        }

        public static void Sortarr(string[] arr)
        {
            int n = arr.Length - 1;
            Array.Sort(arr);
            Console.WriteLine(Commprefix(arr[0], arr[n]));
        }
    }
    

}
