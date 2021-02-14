using System;

namespace DumblePair
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int count = 0;
            int []a = new int[100000];
            n = Int32.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                int m = a[i] % 2;
                count += a[i] / 2;
                a[i + 1] += m;

            }
            Console.WriteLine(count);
        }
    }
}
