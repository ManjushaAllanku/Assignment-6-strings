using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romantointegers
{
    class Romanintegers
    {

        public static int Romanvalue(char  x)
        {
               if(x=='I')                    
                return 1;

                if(x == 'V')
                    return 5;
                    
               if(x=='X')
                return 10;
                    
                if(x=='L')
                return 50;
                    
               if(x=='C')
                return 100;
                    
               if(x=='D')
                        return 500;

            if (x == 'M')

                return 1000;

            else
                return -1;
                
            }
                                
        

        public static int Romantodecimal(string s)
        {
            int res = 0;
           
            for (int i = 0; i < s.Length ; i++)
            {
                s = s.ToUpper();
                if (s.Length == 0)
                
                   // Console.WriteLine("invalid input");
                    return -1;
               
                if (i != s.Length - 1 && Romanvalue(s[i]) < Romanvalue(s[i + 1]))
                {
                    res = res + (Romanvalue(s[i + 1]) - Romanvalue(s[i]));
                    i++;
                }
                else
                    res = res + Romanvalue(s[i]);
            }
            return res;

        }

        public static void Main(string[] args)
        {
            string str="x";
            Romantodecimal(str);
            Console.WriteLine("given roman "   + str +  "  to integer " + Romantodecimal(str));
                Console.ReadKey();
        }
    }
}
