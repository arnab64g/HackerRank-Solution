using System;
namespace CavityMap
{
    class Program
    {
        static char iscavid(char ch, char[] sround){
            char c;
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                if (ch > sround[i])
                    count++;
                else break;
            }
            if (count == 4)
                c = 'X';
            else c = ch;
            return c;
        }
        static void Main(string[] args)
        {
            char[] st = new char[4];
            int n = int.Parse(Console.ReadLine());
            string []str = new string[n];
            char[][] s = new char[n][];
            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
                s[i] = str[i].ToCharArray();
            }
            for (int i = 1; i < n-1; i++)
                for (int j = 1; j < n-1; j++)
                {
                    st[0] = s[i-1][j];
                    st[1] = s[i][j-1];
                    st[2] = s[i][j+1];
                    st[3] = s[i+1][j];   
                    s[i][j] = iscavid(s[i][j], st);
                }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(s[i][j]);
                Console.WriteLine();
            }
        }
    }
}
