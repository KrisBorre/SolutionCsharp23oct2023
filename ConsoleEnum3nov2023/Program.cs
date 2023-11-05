internal class Program
{
    #region Enum.Parse

    enum PetType
    {
        None,
        Cat = 1,
        Dog = 2
    }

    #endregion

    private static void Main(string[] args)
    {
        #region Enum.Parse
        {
            Console.WriteLine("Use the Enum.Parse and TryParse methods to convert strings to enums.");

            Console.WriteLine("An example. " +
                "The Enum.Parse method is a static method in the System namespace, so you will need to include System at the top of your file or use the fully qualified name.");

            Console.WriteLine("Program: Here we see an enum type \"PetType\" containing a constant \"Dog\" with value of 2.");

            Console.WriteLine("Part 1: We call Enum.Parse. " +
                "The typeof(PetType) returns the enum type. " +
                "We cast the result of Enum.Parse to the PetType enum type.");

            Console.WriteLine("Part 2: At the end, we test the result of the Enum.Parse method. " +
                "We print a short message if the test succeeds.");

            #region string
            {
                string value = "Dog";

                // Part 1: try to convert the string to an enum.
                PetType pet = (PetType)Enum.Parse(typeof(PetType), value);

                // Part 2: see if the conversion succeeded.
                if (pet == PetType.Dog)
                {
                    Console.WriteLine("Equals dog.");
                }
            }
            #endregion

            Console.WriteLine("Exceptions. " +
                "An exception may be raised when parsing enums. " +
                "When the contents of the string you try to parse is not represented in the enum, you must handle the exception.");

            Console.WriteLine("Example: Please look at the try-catch block. " +
                "The code catches all errors, which is sufficient for many small applications.");

            Console.WriteLine("String: The string in the example isn't found in the enum PetType, so the enum variable is set to PetType.None.");

            Console.WriteLine("Note: This is the fallback behavior. " +
                "For important applications, you will log the exception.");

            #region Exception            
            {
                // The enum doesn't contain this value.
                string value = "Bat";

                // Try to convert the string to an enum.
                PetType pet;
                try
                {
                    pet = (PetType)Enum.Parse(typeof(PetType), value);
                }
                catch (Exception exception)
                {
                    // The conversion failed.
                    Console.WriteLine("FAILED");
                    Console.WriteLine(exception.Message);

                    // Set fallback value.
                    pet = PetType.None;
                }

                // See if the conversion succeeded.
                if (pet == PetType.Dog)
                {
                }

                // FAILED
                // Requested value 'Bat' was not found.

            }
            #endregion
        }
        #endregion
    }
}