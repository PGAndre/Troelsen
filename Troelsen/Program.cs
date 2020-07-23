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

            void DigitSeparators()
            {
                Console.WriteLine("=> Use Digit Separators:");
                Console.Write("Integer:");
                Console.WriteLine(123_456);
                Console.Write("Long:");
                Console.WriteLine(123_456_789L);
                Console.Write("Float:");
                Console.WriteLine(123_456.1234F);
                Console.Write("Double:");
                Console.WriteLine(123_456.12);
                Console.Write("Decimal:");
                Console.WriteLine(123_456.12M);
            }

            DigitSeparators();


            void BinaryLiterals()
            {
                Console.WriteLine("=> Use Binary Literals:");
                Console.WriteLine("Sixteen: {0}", 0b0001_0000);
                Console.WriteLine("Thirty Two: {0}", 0b0010_0000);
                Console.WriteLine("Sixty Four: {0}", 0b0100_0000);
            }

            BinaryLiterals();


            void StringEquality()
            {
                Console.WriteLine("=> String equality:");
                string s1 = "Hello!";
                string s2 = "Yo!";
                Console.WriteLine("s1 = {0}", s1);
                Console.WriteLine("s2 = {0}", s2);
                Console.WriteLine();

                // Test these strings for equality.
                Console.WriteLine("s1 == s2: {0}", s1 == s2);
                Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
                Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
                Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
                Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
                Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
                Console.WriteLine();
            }

            StringEquality();


            void StringEqualitySpecifyingCompareRules()
            {
                Console.WriteLine("=> String equality (Case Insensitive:");
                string s1 = "Hello!";
                string s2 = "HELLO!";
                Console.WriteLine("s1 = {0}", s1);
                Console.WriteLine("s2 = {0}", s2);
                Console.WriteLine();

                // Check the results of changing the default compare rules.
                Console.WriteLine("Default rules: s1={0},s2={1}s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
                Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
                Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
                Console.WriteLine();
                Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
                Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
                Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
                Console.WriteLine();
            }

            StringEqualitySpecifyingCompareRules();

            void FunWithStringBuilder()
            {
                Console.WriteLine("=> Using the StringBuilder:");

                // Make a StringBuilder with an initial size of 256.
                StringBuilder sb = new StringBuilder("**** Fantastic Games ****", 256);

                sb.Append("\n");
                sb.AppendLine("Half Life");
                sb.AppendLine("Beyond Good and Evil");
                sb.AppendLine("Deus Ex 2");
                sb.AppendLine("System Shock");
                Console.WriteLine(sb.ToString());

                sb.Replace("2", "Invisible War");
                Console.WriteLine(sb.ToString());
                Console.WriteLine("sb has {0} chars.", sb.Length);
                Console.WriteLine();
            }

            FunWithStringBuilder();




            Console.ReadKey();
        }
    }
}
