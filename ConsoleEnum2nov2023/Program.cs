internal class Program
{
    #region Enum.Parse

    enum Importance
    {
        None,
        Low,
        Medium,
        Critical
    }

    #endregion

    private static void Main(string[] args)
    {
        #region TryParse
        {
            // https://www.dotnetperls.com/enum-parse

            Console.WriteLine("Test the result of Enum.TryParse for true or false. " +
                "If the method returns true, then the string was successfully parsed.");

            string value = "Medium";

            // An uninitialized variable.
            Importance importance1;

            // Call Enum.TryParse method.
            if (Enum.TryParse(value, out importance1))
            {
                // We now have an enum type.
                Console.WriteLine(importance1 == Importance.Medium); // True
            }

            Console.WriteLine("A quirk. The Enum.TryParse method will parse a string representation of a number as an enum value. " +
                "This behavior might not be expected. " +
                "Consider using the Enum.IsDefined method to test.");

            Console.WriteLine("Tip: Whenever you have a string that you want to convert into an enum, consider using the Enum.TryParse static method.");

            Console.WriteLine("TryParse: This method provides a clear and useful calling convention, the tester-doer pattern. " +
                "It requires at least the .NET Framework 4.0.");

            Importance importance2;

            // ... Try to parse the string "1".
            if (Enum.TryParse("1", out importance2))
            {
                // ... "1" is treated as "Low".
                Console.WriteLine(importance2); // Low
            }

            Console.WriteLine("Enum.IsDefined. Please consider calling Enum.TryParse before calling IsDefined. " +
                "If TryParse returns true, and IsDefined succeeds, you have a correct string value.");

            Console.WriteLine("Quote: The example defines a Colors enumeration, calls the TryParse... method to convert strings to their corresponding enumeration values, and calls the IsDefined method.");

            // ... "1" is not defined.
            // ... "Low" is defined.
            Console.WriteLine(Enum.IsDefined(typeof(Importance), "1")); // False
            Console.WriteLine(Enum.IsDefined(typeof(Importance), "Low")); // True

            Console.WriteLine("Enum.Parse receives the typeof operator result and the string input. " +
                "We saw a successful call to Enum.Parse — and one that failed and threw an exception.");


        }
        #endregion
    }
}