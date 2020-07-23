using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //
            ParseFromStringsWithTryParse();

            Console.ReadKey();
        }
    }
}
