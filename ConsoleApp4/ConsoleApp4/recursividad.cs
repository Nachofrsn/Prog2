using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());
            int n = Facto(num);
            Console.WriteLine("resultado: " + n);
            Console.ReadKey();
        }

        /*
        static void Factorial(int num, out int result)
        {
            if (num >= 0) {
                result = num;
                for (int a = num - 1; a > 0; a--)
                {
                    result *= a;
                }
            }
            else
            {
                Exception e = new Exception("error en entero");
                throw e;
            } 

        }
        */

        static int Facto(int num)
        {
            if (num > 1)
            {
                return num * Facto(num - 1);
            }
            else
            {
                return 1; 
            }
        }
    }
}



          

            
            
            

