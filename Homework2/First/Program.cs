using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        { 
            bool sushu(int num)
            {
                for(int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }

            Console.WriteLine("Please input an integer");
            var a1 = Console.ReadLine();
            int a2 = int.Parse(a1);
            int a3;
            int.TryParse(a1, out a3);
            int a = Convert.ToInt32(a1);
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    if (sushu(i))
                        Console.WriteLine(i + '\n');
                }
                    
                
            }
        }
    }
}

    