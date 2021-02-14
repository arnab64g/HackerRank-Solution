using System;

namespace MaxLuck
{
    class Program
    {
        struct contest
        {
            public int luck;
            public int import;
        }
        static void Main(string[] args)
        {
            int n, k;
            string []s= Console.ReadLine().Split(' ');
            n = int.Parse(s[0]);
            k = int.Parse(s[1]);
            contest[] list = new contest[n];
            int [] notzero = new int[n];
            int top = -1;
            int maxpoint = 0;
            for (var i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split(' ');
                list[i].luck = int.Parse(s[0]);
                list[i].import = int.Parse(s[1]);
                if (list[i].import != 0)
                    notzero[++top] = list[i].luck;
            }
            Array.Sort(notzero, 0, top+1);
            while (top-- >= 0)
            {
                if (k-- > 0)
                    maxpoint += notzero[top+1];
                else
                    maxpoint -= notzero[top+1];
            }
            for (var i = 0; i < n; i++)
                if (list[i].import == 0)
                    maxpoint += list[i].luck;
            Console.WriteLine(maxpoint);
        }
    }
}
