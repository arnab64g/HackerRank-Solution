using System;

namespace WiredNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            string v = Console.ReadLine();
            int input = Convert.ToInt32(v);
            //input = Convert.ToInt32(rs);
            
            if(input % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (input %2 == 0) {
                if(input >= 2 && input <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (input >= 6 && input <= 20)
                {
                    Console.WriteLine("Weird");
                }
                else if (input % 2 == 0 && input > 20)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (input % 2 != 0)
                {
                    Console.WriteLine("Weird");
                }
            }
            
        }
    }
}
