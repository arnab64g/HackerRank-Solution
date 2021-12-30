using System;
using System.Collections.Generic;
class Program
{
    public static void Main(String[] args){
        string[] nm = Console.ReadLine().Split(' ');
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);
        Dictionary<string, int> dt = new Dictionary<string, int>();
        string[] s = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            if(dt.ContainsKey(s[i])){
                dt[s[i]]++;
            }
            else dt.Add(s[i], 1);  
        }
        string[] s2 = Console.ReadLine().Split(' ');
        bool res = true;
        for (int i = 0; i < m; i++)
        {
            if (dt.ContainsKey(s2[i]))
            {
                dt[s2[i]]--;
                if(dt[s2[i]] == 0)
                    dt.Remove(s2[i]);
            }
            else{ 
                res = false;
                break;
            }
        }
        if(res)
            Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
}