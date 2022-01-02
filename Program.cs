using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_20
{
    internal class Program
    {
        delegate double CircleCalc(double r);
        static void Main(string[] args)
        {
            
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());

            
            CircleCalc cc;

            
            double length = 0;
            double area = 0;
            double volume = 0;

            
            cc = Length;
            length = cc(r);

            
            cc = Area;
            area = cc(r);

            
            cc = Volume;
            volume = cc(r);

            
            Result(length, area, volume);

            
            Console.WriteLine("\nНажмите любую кнопку");
            Console.ReadKey();

            
            Console.Clear();
            

            
        }
        static double Length(double r)
        {
            
            return Math.PI * r * 2;
        }
        static double Area(double r)
        {
            
            return Math.PI * r * r;
        }
        static double Volume(double r)
        {
            
            return Math.PI * Math.Pow(r, 3) * 4 / 3;
        }
        static void Result(double l, double a, double v)
        {
            Console.WriteLine($"\nДлина: {l}\nПлощадь: {a}\nОбъем: {v}");
        }
    }
}
