using System;
namespace anagram
{
    class Program
    {
        struct setofchar
        {
            public int s1;
            public int s2;
        }
        static void Main(string[] args)
        {
            setofchar[] sc = new setofchar[26];
            int p1, p2;
            for (int i = 0; i < 26; i++)
            {
                sc[i].s1 = 0;
                sc[i].s2 = 0;
            }
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int minlen = (str1.Length <= str2.Length)? str1.Length : str2.Length;
            int maxlen = (str1.Length > str2.Length)? str1.Length : str2.Length;
            char[] ch1 = (str1.Length <= str2.Length) ? str1.ToCharArray(): str2.ToCharArray();
            char[] ch2 = (str1.Length > str2.Length) ? str1.ToCharArray(): str2.ToCharArray();
            for (int i = 0; i < minlen; i++)
            {
                p1 = ch1[i]-'a';
                p2 = ch2[i] - 'a';
                sc[p1].s1++;
                sc[p2].s2++;
            }
            for (int i = minlen; i < maxlen; i++)
            {
                p2 = ch2[i] - 'a';
                sc[p2].s2++;
            }
            int count = 0;
            for (int i = 0; i < 26; i++)
                count += Math.Abs(sc[i].s1 - sc[i].s2);
            Console.WriteLine(count);
        }
    }
}
