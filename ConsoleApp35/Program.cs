using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    // input string = "abcade"

    // test case
    // coincedence:
    // {"abcadebc"} = 3 (a,b,c)
    // { "ab", "bc","ca", "ad","de","eb","bc" } = 1 (bc)
    // { "abc", "bca", "cad", "ade", "deb", "ebc"} = 0
    // Number of coincedence = 4

    internal class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            string s = "abcadebc";
            
            List<string> ls = s.ToCharArray().Select(c => c.ToString()).ToList();

            for (int i = 1; i <= s.Length/2; i++) 
            {
                List<string> list = GetWindowList(s, i);
                res += NumDouble(list);
            }

            Console.WriteLine($"number of coincedence = {res}");
            Console.ReadKey();
        }

        static int NumDouble(List<string> ls) 
        {
            return ls.Count - ls.Distinct().ToList().Count;           
        }

        static List<string> GetWindowList(string ls, int winSize)
        {            
            List<string> resList = new List<string>();

            if (winSize > 0)
            {
                
                for (int i = 0; i <= ls.Length - winSize; i++)
                {
                    resList.Add(ls.Substring(i, winSize));                    
                }
            }

            return resList;
        }
    }
}
    