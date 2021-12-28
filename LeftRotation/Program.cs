using System;
namespace LeftRotation
{
    class Program
    {
        public static void Main(string[] args){
            
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            string[] value = Console.ReadLine().Split(' ');
            for (int i = m; i < n; i++)
            {
                Console.Write(value[i] + " ");
            }
            for (int i = 0; i < m; i++)
            {
                Console.Write(value[i]+" ");
            }
            Console.WriteLine();
        }
    }
}