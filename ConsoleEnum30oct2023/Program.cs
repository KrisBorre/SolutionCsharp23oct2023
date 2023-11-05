internal class Program
{
    #region Switch Enum

    enum Priority
    {
        Zero,
        Low,
        Medium,
        Important,
        Critical
    };

    static bool IsImportant(Priority priority)
    {
        // Switch on the Priority enum.
        switch (priority)
        {
            case Priority.Low:
            case Priority.Medium:
            case Priority.Zero:
            default:
                return false;
            case Priority.Important:
            case Priority.Critical:
                return true;
        }
    }

    #endregion

    private static void Main(string[] args)
    {
        #region Switch Enum
        {
            Console.WriteLine("Switch can act upon enum values. " +
                "An enum switch sometimes results in clearer code. " +
                "It sometimes is faster. " +
                "This code pattern is often effective. " +
                "It is used in many real-world programs, not just website examples.");

            Console.WriteLine("Enums are useful in your program if it has to use magic constants. " +
                "For the switch statement, look at the IsImportant method defined at the bottom of this example. " +
                "It uses 5 explicit cases and a default case.");

            Console.WriteLine("IsImportant: This method contains a switch that tests the parameter of type Priority. " +
                "It returns true if the Priority value is Important or Critical.");

            // New local variable of the Priority enum type.
            Priority priority = Priority.Zero;

            // Set priority to critical on Monday.
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                priority = Priority.Critical;
            }

            // Write this if the priority is important.
            if (IsImportant(priority))
            {
                Console.WriteLine("The problem is important.");
            }

            // See if Low priority is important.
            priority = Priority.Low;
            Console.WriteLine(IsImportant(priority)); // False

            // See if Important priority is important.
            priority = Priority.Important;
            Console.WriteLine(IsImportant(priority)); // True

            Console.WriteLine("How is the enum switch compiled? " +
                "The above C# code is compiled into a special .NET Framework instruction called a jump table. " +
                "The jump table uses the IL instruction switch. " +
                "It defines one jump \"point\" to each case.");

            Console.WriteLine("Switch can improve performance when it is implemented by a jump table in the MSIL. " +
                "This is determined by the compiler.");



        }
        #endregion    
    }
}