using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Troelsen
{
    class Program
    {
        static void Main(string[] args)
        {
            void ParseFromStringsWithTryParse()
            {
                Console.WriteLine("=> Data type parsing with TryParse:");
                if (bool.TryParse("True", out bool b)) ;
                {
                    Console.WriteLine("Value of b: {0}", b); // Вывод значения b
                }
                string value = "Hello";
                if (double.TryParse(value, out double d))
                {
                    Console.WriteLine("Value of d: {0}", d); // Вывод значения d
                }
                else
                {
                    // Преобразование потерпело неудачу
                    Console.WriteLine("Failed to convert the input ({0}) to a double", value);
                }
                Console.WriteLine();
            }
            
            ParseFromStringsWithTryParse();

            void UseDatesAndTimes()
            {
                Console.WriteLine("=> Dates and Times:");
                // Этот конструктор принимает год, месяц и день.
                DateTime dt = new DateTime(2015, 10, 17);
                // Какой это день месяца?
                Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
                // Сейчас месяц декабрь.
                dt = dt.AddMonths(2);
                Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
                // Этот конструктор принимает часы, минуты и секунды.
                TimeSpan ts = new TimeSpan(4, 30, 0);
                Console.WriteLine(ts);
                // Вычесть 15 минут из текущего значения TimeSpan и вывести результат.
                Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
                
            }
            UseDatesAndTimes();

            void UseBiglnteger()
            {
                Console.WriteLine("=> Use Biglnteger:");
                BigInteger biggy =
                BigInteger.Parse("9999999999999999999999999999999999999999999999");
                Console.WriteLine("Value of biggy is {0}", biggy);
                // значение biggy
                Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
                // biggy - четное?
                Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
                // biggy - степень 2?
                BigInteger reallyBig = BigInteger.Multiply(biggy,
                BigInteger.Parse("8888888888888888888888888888888888888888888"));
                Console.WriteLine("Value of reallyBig is {0}", reallyBig);
                // значение reallyBig
            }
            UseBiglnteger();


                            Console.ReadKey();
        }
    }
}
