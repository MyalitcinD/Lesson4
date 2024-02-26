using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int neg_count, pos_count, N;
            neg_count = pos_count = 0;
            Console.WriteLine("Вводите последовательность через чисел ENTER");
            do {
                
                N = Convert.ToInt32(Console.ReadLine());
                if(N>0) {
                    pos_count += 1;
                }
                else if(N<0) {
                    neg_count += 1;
                }

            } while(N!=0);
            if(neg_count>pos_count) {
                Console.WriteLine("Отрицательных чисел больше положительных");
            }
            else if(neg_count < pos_count) {
                Console.WriteLine("Положительных чисел больше отрицательных");
            }
            else {
                Console.WriteLine("Положительных и отрицательных чисел поровну");
            }
            Console.ReadKey();
        }
    }
}
