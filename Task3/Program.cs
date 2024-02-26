using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны прямоугольника A и B и сторону квадрата C через ENTER");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int count_c = 0;
            if((A < C) || (B < C)) {
                Console.WriteLine("невозможно разместить квадрат в заданный прямоугольник");
            }
            else {
                int len = 0;
                //int count_c = 0;
                while((len + C) <= A) {
                    int hight = C;
                    while((hight + C) <= B) {
                        hight += C;
                        count_c += 1;
                    }
                    count_c += 1;
                    len += C;
                }
            }
            Console.WriteLine("В прямоугольник {0} на {1} поместиться {2} квадратов со стороной {3}", A, B, count_c, C);
            Console.ReadKey();
        }
    }
}
