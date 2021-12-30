using System;
using System.Collections.Generic;
class Program
{
    public static void Main(String[] args){
        int n = Int32.Parse(Console.ReadLine());
        Dictionary<string, int> dt = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            if(dt.ContainsKey(s)){
                dt[s]++;
            }
            else dt.Add(s, 1);
            
        }
        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            string s = Console.ReadLine();
            if (dt.ContainsKey(s))
            {
                Console.WriteLine(dt[s]);
            }
            else Console.WriteLine(0);
        }
    }
}