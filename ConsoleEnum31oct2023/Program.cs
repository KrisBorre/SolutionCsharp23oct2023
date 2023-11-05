internal class Program
{
    #region Enum ToString

    enum Priority
    {
        None,
        Trivial,
        Normal,
        Important,
        Critical
    }

    #endregion

    private static void Main(string[] args)
    {
        #region Enum ToString
        {
            // https://www.dotnetperls.com/enum-tostring

            Console.WriteLine("Enum.ToString. " +
                "This converts an enum into a string. " +
                "This string can be used to display the name of the enum. " +
                "It can be stored in a string variable or field.");

            Console.WriteLine("To declare an enum type we use the enum keyword. " +
                "The enumerated constants can be any identifier, and their actual values are automatically incremented.");

            Console.WriteLine("Next: In this program, the Priority.None enum will have value of 0. " +
                "And the Priority.Critical enum will have value of 4.");

            Console.WriteLine("Note: The ToString virtual method will look into the assembly metadata to get the string value to return.");

            Console.WriteLine("Tip: The first enumerated constant in an enum should be a \"None\" or \"Zero\" value so it can be correctly tested against zero.");

            Console.WriteLine("Finally: We print the 5 string values in the enum. " +
                "The GetNames method returns the same strings.");

            Priority priorityValue = Priority.Important;
            string enumValue = priorityValue.ToString();

            // Loop through enumerations.
            // ... Write string representations.
            Console.WriteLine("::FOR::");
            for (Priority priority = Priority.None;
                priority <= Priority.Critical;
                priority++)
            {
                string value = priority.ToString();
                Console.WriteLine(value);
            }

            Console.WriteLine("::GETVALUES::");
            foreach (Priority priority in Enum.GetValues(typeof(Priority)))
            {
                string value = priority.ToString();
                Console.WriteLine(value);
            }

            //::FOR::
            //None
            //Trivial
            //Normal
            //Important
            //Critical
            //::GETVALUES::
            //None
            //Trivial
            //Normal
            //Important
            //Critical

            Console.WriteLine("There is a static Enum.GetNames method that receives one Type parameter in the Enum class. " +
                "This method provides a clearer way to get an array of all of the enum strings.");

            Console.WriteLine("It is preferable to use the GetNames method instead of the for-loop construct as shown. " +
                "There are drawbacks to both approaches.");
        }
        #endregion
    }
}