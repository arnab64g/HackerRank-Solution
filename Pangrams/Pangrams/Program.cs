using System;

namespace Pangrams
{
    class Program
    {
        static String IsPangrams(String line)
        {
            String result = "pangram";
            bool[] status = new bool[26];
            Char[] stc = line.ToCharArray();
            int len = stc.Length;
            for(int i = 0; i < len; i++)
            {
                if (Char.IsLower(stc[i]))
                {
                    status[stc[i] - 'a'] = true;
                }
                else if (Char.IsUpper(stc[i]))
                {
                    status[stc[i] - 'A'] = true;
                }
            }
            for(int i = 0; i <26; i++)
            {
                if(status[i] == false)
                {
                    result = "not pangram";
                    break;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            Console.WriteLine(IsPangrams(s));
        }
    }
}
