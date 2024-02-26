using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N>0 для ");
            int N = Convert.ToInt32(Console.ReadLine());
            int res = 0 ;
            Console.WriteLine(" ");
            if(N < 0) {
                Console.WriteLine("N введен меньше 0");
            }
            else {
                for(int i = 1; i <= N; i++) {
                    res += 2 * i - 1;
                    Console.WriteLine("{0}",res);
                }
            
            }
            Console.WriteLine("N^2 = {0} ",res);
            Console.ReadKey();       
        }
    }
}
