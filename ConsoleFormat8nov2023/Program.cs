internal class Program
{
    #region https://www.dotnetperls.com/format

    static string Method1()
    {
        return 100.ToString("0.0 MB");
    }

    static string Method2()
    {
        return 100.ToString("0.0") + " MB";
    }

    #endregion

    private static void Main(string[] args)
    {
        #region https://www.dotnetperls.com/format
        {
            Console.WriteLine("Insert values into a string with string.Format. " +
                "Specify percentages, decimals and padding.");
            Console.WriteLine("With formatting, we change how data appears. " +
                "The string.Format method helps. " +
                "We use it to change how numbers are printed. " +
                "We use format codes.");
            Console.WriteLine("First, we use string.Format to combine 3 strings with formatting options. " +
                "The format string itself is the first argument. " +
                "It is usually specified as a string literal.");
            Console.WriteLine("Markers: The 0, 1 and 2 are where the first, second and third arguments are inserted. " +
                "A format specification comes after the \":\" char.");
            Console.WriteLine("Variables: The program formats 3 variables. " +
                "These are a string, an int and a DateTime struct.");
            Console.WriteLine("Result: The string has formatting applied. " +
                "The int is displayed with a decimal place. " +
                "The year is displayed with 4 digits.");

            {
                // Declare three variables.
                // ... The values they have are not important.
                string value1 = "Dot Net Perls";
                int value2 = 10000;
                DateTime value3 = new DateTime(2023, 11, 8);
                // Use string.Format method with four arguments.
                // ... The first argument is the formatting string.
                // ... It specifies how the next arguments are formatted.
                string result = string.Format("{0}: {1:0.0} - {2:yyyy}", value1, value2, value3);
                // Write the result.
                Console.WriteLine(result); // Dot Net Perls: 10000,0 - 2023                                          
            }

            Console.WriteLine("We can specify that a value (like a double) can be formatted inside string.Format. " +
                "A format string is the first argument to string.Format.");
            Console.WriteLine("Note: The format string in this example uses the 0:0.0 % syntax. " +
                "This means that the second argument is formatted with the pattern 0.0 %.");
            Console.WriteLine("Digits: The \"0.0 %\" part specifies the number of digits. " +
                "We can have many digits before the decimal place, but only one after it.");
            // Format a ratio as a percentage string.
            // ... You must specify the percentage symbol.
            // ... It will multiply the value by 100.

            {
                double ratio = 0.73;
                string result = string.Format("string = {0:0.0%}", ratio);
                Console.WriteLine(result); // string = 73,0%                                         
            }

            Console.WriteLine("Padding. " +
                "This can be expressed declaratively in format strings. " +
                "Padding inserts characters at the left or right of the string to reach a specified length.");
            Console.WriteLine("Tip: Instead of the PadLeft and PadRight methods, you can use the string.Format method with special substitutions.");
            Console.WriteLine("Sizes: Use the comma char followed by the padding size. " +
                "A negative number will add padding to the right (left-align).");
            Console.WriteLine("Also: You can use a positive padding size to add padding to the left. " +
                "This will right-align the string.");

            {
                // The constant formatting string.
                // ... It specifies the padding.
                // ... A negative number means to left-align.
                // ... A positive number means to right-align.
                const string format = "{0,-10} {1,10}";
                // Construct the strings.
                string line1 = string.Format(format, 100, 5);
                string line2 = string.Format(format, "Carrot", "Giraffe");
                // Write the formatted strings.
                Console.WriteLine(line1);
                Console.WriteLine(line2);
            }

            Console.WriteLine("Sometimes, you need to just format a single number, like an integer or long. " +
                "In this case, you don't need to use string.Format. " +
                "You can just use the ToString virtual method.");

            {
                int value = 123;
                string a = string.Format("{0:0000}", value); // Too complex.
                string b = value.ToString("0000"); // Simpler.
                Console.WriteLine(a); // 0123
                Console.WriteLine(b); // 0123
            }

            Console.WriteLine("Hex is a number representation. " +
                "We use format strings and the ToString method to convert ints to hex format. " +
                "The int.Parse method can then be used to convert them back.");
            Console.WriteLine("Code: X formats as hexadecimal. " +
                "You can specify X and then a number (such as X8) to pad the output on the left side with zeros.");
            Console.WriteLine("Tip: You can use the NumberStyles.AllowHexSpecifier argument to make int.Parse handle hex numbers.");

            {
                int value1 = 10995;

                // Write number in hex format.
                Console.WriteLine("{0:x}", value1); // 2af3
                Console.WriteLine("{0:x8}", value1); // 00002af3

                Console.WriteLine("{0:X}", value1); // 2AF3
                Console.WriteLine("{0:X8}", value1); // 00002AF3

                // Convert to hex.
                string hex = value1.ToString("X8");

                // Convert from hex to integer.
                int value2 = int.Parse(hex, System.Globalization.NumberStyles.AllowHexSpecifier);
                Console.WriteLine(value1 == value2); // True
            }

            // Console.WriteLine("{0} {2}", "x");
            Console.WriteLine("The System.FormatException is thrown because the {2} substitution marker was not found in the argument list.");
            Console.WriteLine("Whenever we encounter a FormatException, it is worthwhile to check substitution markers and argument lists for formatting methods.");
            Console.WriteLine("Benchmark, ToString. " +
                "When creating complex strings, we are tempted to use concatenations. " +
                "But we can achieve better performance by unifying the string operations.");
            Console.WriteLine("Here: We look at a program that compares 2 methods of creating a formatted string.");
            Console.WriteLine("Version 1: The Method1 version of the logic uses a single format string. " +
                "The MB part is inside the format string.");
            Console.WriteLine("Version 2: This version uses a format string and then another concatenation after that.");
            Console.WriteLine("Result: Method1 is faster. " +
                "With string.Format and ToString, we can combine literal concatenations in the format for better performance.");            

            {
                const int _max = 1000000;
                var s1 = System.Diagnostics.Stopwatch.StartNew();
                // Version 1: use a format string to create the complete string.
                for (int i = 0; i < _max; i++)
                {
                    Method1();
                }
                s1.Stop();
                var s2 = System.Diagnostics.Stopwatch.StartNew();
                // Version 2: use a format string and then concatenate.
                for (int i = 0; i < _max; i++)
                {
                    Method2();
                }
                s2.Stop();
                Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000 * 1000) / _max).ToString("0.00 ns"));
                Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000 * 1000) / _max).ToString("0.00 ns"));
            }

            // 97,96 ns    Format string
            // 92,82 ns    Format string and concat

            Console.WriteLine("For simple format strings, we can use string interpolation instead of the string.Format method. " +
                "This has clearer syntax that is validated by the compiler.");

            {
                int value = 100;
                // String interpolation can be used instead of a format string.
                Console.WriteLine($"The size is {value}.");
            }

            Console.Read();
        }
        #endregion

    }
}