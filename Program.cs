using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача__1
{
    class Program
    {
        static void Main(String[] args)
        {
            double X, Y;
            Console.WriteLine("Введите X координату точки: ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y координату точки: ");
            Y = Convert.ToDouble(Console.ReadLine());
            if ((X*X+Y*Y)<=1 & Y>0 & (X<0 | X*X+Y*Y>=0.5))
                Console.WriteLine("Точка принадлежит заштрихованной области.");
            else
                Console.WriteLine("Точка НЕ принадлежит заштрихованной области.");
            Console.ReadLine();


        }
    }
}
