internal class Program
{
    #region enum examples 

    enum Importance
    {
        None,
        Trivial,
        Regular,
        Important,
        Critical
    }

    enum CaseColor
    {
        Uncolored = 0,
        Red = 8001,
        Blue = 9001
    }

    enum TagType
    {
        None,
        BoldTag,
        ItalicsTag,
        HyperlinkTag,
    }

    enum Visibility
    {
        None,
        Hidden = 2,
        Visible = 4
    }

    enum AnimalType
    {
        None,
        Cat = 1,
        Dog = 2
    }

    enum FormatType
    {
        None,
        BoldFormat,    // Is a format value.
        ItalicsFormat, // Is a format value.
        Hyperlink      // Not a format value.
    }

    /// <summary>
    /// Returns true if the FormatType is Bold or Italics.
    /// </summary>
    static bool IsFormat(FormatType value)
    {
        switch (value)
        {
            case FormatType.BoldFormat:
            case FormatType.ItalicsFormat:
                {
                    // These 2 values are format values.
                    return true;
                }
            default:
                {
                    // The argument is not a format value.
                    return false;
                }
        }
    }

    enum CatFurColor
    {
        None,
        Orange,
        Grey
    };

    static CatFurColor _color;

    #endregion


    private static void Main(string[] args)
    {
        #region enum examples
        {
            // https://www.dotnetperls.com/enum

            Console.WriteLine("Store named and magic constants with enums. " +
                "Use enums in collections, if and switch.");

            Console.WriteLine("Enum example. " +
                "Here is an enum that expresses importance. " +
                "An enum type internally contains an enumerator list. " +
                "The values (like Trivial and Critical) are ints like 1 and 4.");

            Console.WriteLine("Int: The underlying value of this enum is the default, which is int. " +
                "When we use an Importance variable, we are using an int.");

            Console.WriteLine("If: We test the enum value with an if-statement that includes an if-else block. " +
                "The value is Critical, so \"True\" is printed.");

            // ... An enum local variable.
            Importance value = Importance.Critical;

            // ... Test against known Importance values.
            if (value == Importance.Trivial)
            {
                Console.WriteLine("Not true");
            }
            else if (value == Importance.Critical)
            {
                Console.WriteLine("True");
            }

            Console.WriteLine("Enum advantages. " +
                "With an enum, magic constants are separate. " +
                "This modular design makes things easier to understand. " +
                "Fewer bugs will be introduced.");

            Console.WriteLine("Example: Consider this program — the color Blue is supposed to have the value 9001. " +
                "We can store this in an enum to ease maintenance.");

            Console.WriteLine("IntelliSense: Enums can be used with IntelliSense in Visual Studio. " +
                "This feature will guess the value you are typing.");

            Console.WriteLine("Press tab: We can simply press tab and select the enum type we want. " +
                "This is an advantage to using enum types.");

            // This makes sense to read.
            Console.WriteLine("COLOR: {0}, {1}", CaseColor.Blue, (int)CaseColor.Blue);

            // This is more confusing to read.
            Console.WriteLine("COLOR: {0}, {1}", "Blue", 9001);

            Console.WriteLine("Debugger. " +
                "We examine what enums look like in the Visual Studio debugger. " +
                "We see that enums are strongly-typed. " +
                "You cannot assign them to just any value.");

            Console.WriteLine("Note: The debugger shows that \"tagValue\" is of type Program.TagType. " +
                "Internally it is represented as an integer.");

            // Specify a tag instance.
            TagType tagValue = TagType.BoldTag;

            if (tagValue == TagType.BoldTag)
            {
                // Will be printed.
                Console.WriteLine("Bold");
            }
            if (tagValue == TagType.HyperlinkTag)
            {
                // This is not printed.
                Console.WriteLine("This is not printed.");
            }

            Console.WriteLine("Strings. " +
                "We convert enums to strings for display on the Console. " +
                "Enum values always have a name, such as TagType.None (in the above example).");

            Console.WriteLine("Tip: To print out the enum values, you can call ToString on the enum variable in a program.");

            Console.WriteLine("Also: Another method such as Console.WriteLine can automatically call the ToString method.");

            Console.WriteLine("ToString: Internally, ToString invokes methods that use reflection to acquire the string representation.");

            // ... Two enum variables.
            AnimalType animal = AnimalType.Dog;
            Visibility visible = Visibility.Hidden;

            // ... Use Console.WriteLine to print out their values.
            Console.WriteLine(animal);
            Console.WriteLine(visible);

            Console.WriteLine("Switch. " +
                "We often use if-statements with enums. " +
                "But switch is another option. " +
                "And switch is sometimes compiled to more efficient IL.");

            Console.WriteLine("Switch Enum");

            Console.WriteLine("IsFormat: This method works as a filter that tells us something about sets of enum values — it contains a switch statement.");

            Console.WriteLine("Logic: We can separate the logic here instead of repeating ourselves. " +
                "This helps clarify the program logic.");

            // ... Test enum with switch method.
            FormatType formatValue = FormatType.None;
            if (IsFormat(formatValue))
            {
                // This is not reached, as None does not return a true value in IsFormat.
                Console.WriteLine("Error");
            }

            // ... Test another enum with switch.
            formatValue = FormatType.ItalicsFormat;
            if (IsFormat(formatValue))
            {
                // This is printed, as we receive true from IsFormat.
                Console.WriteLine("True");
            }

            Console.WriteLine("Default. " +
                "Values are always initialized to zero when they are fields of a class. " +
                "Upon class creation, an enum field will also be initialized to zero (and the equivalent value).");

            Console.WriteLine("Tip: To make enums valid, always use the default value of zero. " +
                "This way, we can test for the default value of fields.");

            Console.WriteLine("Sometimes: This issue is not worth fixing. " +
                "But it is often useful for verifying correctness.");

            Console.WriteLine("Also: You can place a semicolon at the end of an enum block (but this is not required or helpful usually).");

            // The enum is a field, so it has its default value of None.
            Console.WriteLine("DEFAULT ENUM VALUE: {0}", _color);

        }
        #endregion

    }
}