using System;

namespace MinimumSwap
{
    class Program
    {
        static int MinimumSw(int[] a)
        {
            int n = 0;
            int len = a.Length;
            int swloc, temp; 
            for(int i = 0; i < len; i++)
            {
                while(a[i] != i + 1)
                {
                    n++;
                    swloc = a[i] - 1;
                    temp = a[swloc];
                    a[swloc] = a[i];
                    a[i] = temp;
                }
            }
            return n;
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            String[] s = Console.ReadLine().Split(' ');
            int len = s.Length;
            int[] num = new int[len];
            for(int i = 0; i < len; i++)
            {
                num[i] = Int32.Parse(s[i]);
            }
            Console.WriteLine(MinimumSw(num));
        }
    }
}
