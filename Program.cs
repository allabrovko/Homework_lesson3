using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //task.3 Вычисление времени в сек.
            Console.WriteLine("вычисление времени в секундах");
            double a = 2, b = 90, result;
            if (b > 60)
                Console.WriteLine("количество секунд не может быть более 60");
            else
            {
                result = a * 2 + b;
                Console.WriteLine($"Result is: {result}");
            }

            //task.4 Проверка явл. ли год высокосным

            int year = 2001;
            bool error = true;
            if ((year % 4 != 0) || ((year % 400 != 0) && (year % 100 == 0)))
                Console.WriteLine("Невисокосный");
            else
                Console.WriteLine("Високосный");



            //task.7 Вычисление стоимости покупки с уч. скидки
            Console.WriteLine("Вычисление стоимости покупки");
            double d = 1200;
            result = d - ((d * 10) / 100);
            Console.WriteLine($"стоимость покупки без скидки: {d}");
            if (d > 1000)
                Console.WriteLine($"стоимость покупки со скидкой: {result}");

        }
    }
}
