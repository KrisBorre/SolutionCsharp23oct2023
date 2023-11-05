internal class Program
{
    #region see C# program that uses enums with Stack

    enum TagType
    {
        None,         // integer value = 0
        BoldTag,      // 1
        ItalicsTag,   // 2
        HyperlinkTag, // 3
    }

    enum CoffeeSize : byte
    {
        None,
        Tall,
        Venti,
        Grande
    };

    enum Importance : byte
    {
        Low,
        Medium,
        High
    };

    enum Color
    {
        None,
        Blue,
        Red
    }


    [Flags]
    enum DataInfo
    {
        None = 0,
        OptionA = 1,
        OptionB = 2,
        OptionC = 4,
    }


    enum TestType
    {
        None,
        Valid,
        Invalid
    }

    enum Test
    {
        Cat,
        Dog,
        Rabbit
    }

    const int _cat = 0;
    const int _dog = 1;
    const int _rabbit = 2;

    static readonly int _cat2 = 0;
    static readonly int _dog2 = 1;
    static readonly int _rabbit2 = 2;

    static void Method(Test test)
    {
    }

    static void Method(int value)
    {
    }

    #endregion


    private static void Main(string[] args)
    {
        #region   C# program that uses enums with Stack
        {
            // https://www.dotnetperls.com/enum

            Console.WriteLine("Collections. " +
                "Here we apply the Stack collection in the .NET Framework. " +
                "With Stack, we can develop a parser that keeps the most recently encountered enum value on the top.");

            Console.WriteLine("Stack: The Stack here can only have TagType values added to it. " +
                "This is an example of type checking and validation.");

            Console.WriteLine("System.Collections.Generic.Stack");

            Console.WriteLine("Pop: With the Pop method we get the top element from the stack. " +
                "This is of type TagType.ItalicsTag.");

            Console.WriteLine("Result: In the execution of this program, the stack has two enums added and one removed.");

            // Create a Stack of enums.
            var stack = new System.Collections.Generic.Stack<TagType>();

            // ... Add enum values to our Stack.
            stack.Push(TagType.BoldTag); // Add bold.
            stack.Push(TagType.ItalicsTag); // Add italics.

            // ... Get the top enum value.
            TagType thisTag = stack.Pop(); // Get top tag.
            System.Console.WriteLine("POP RESULT: " + thisTag);

            // Peek at the top.
            var peeked = stack.Peek();
            System.Console.WriteLine("PEEK RESULT: " + peeked);

            Console.WriteLine("Type. " +
                "An enum has an underlying type. " +
                "Each time we use the enum, we are using the underlying type. " +
                "The enum has syntactic sugar on top.");

            Console.WriteLine("Int: Enums are by default an int type, but we can adjust this to a different numeric type.");

            Console.WriteLine("Byte: Here we create an enum with a type of byte. " +
                "This is sometimes useful on small enums. " +
                "A byte can only contain 256 different values.");

            Console.WriteLine("Memory: The CoffeeSize enum will use memory equivalent to a byte. " +
                "This can make classes more efficient and smaller.");

            // ... Create a coffee size local.
            CoffeeSize size = CoffeeSize.Venti;
            Console.WriteLine(size);

            Console.WriteLine("GetUnderlyingType. " +
                "We can determine an enum's type (like int) at runtime. " +
                "Enum.GetUnderlyingType, a static method, determines the underlying type.");

            Console.WriteLine("Next: We declare an enum Importance. " +
                "For this example it uses an underlying type of byte.");

            Console.WriteLine("Then: When the GetUnderlyingType method is called, the System.Byte type is returned.");

            // Determine the underlying type of the enum.
            Type type = Enum.GetUnderlyingType(typeof(Importance));
            Console.WriteLine(type); // System.Byte

            Console.WriteLine("Null, none. An enum value cannot be null. " +
                "It is a value type like an int. " +
                "To avoid the \"cannot convert null\" error, use a special None constant as the first enum item.");

            // Color c = null; // Error CS0037  Cannot convert null to 'Color' because it is a non-nullable value type

            Console.WriteLine("Flags. The C# language allows us to specify a Flags attribute on an enum. " +
                "This enables the enum to be used as a bit field. " +
                "We can use combinations of enum values this way.");

            Console.WriteLine("Here: We have an enum called DataInfo that has 4 different flag values. " +
                "We set 2 of them at once in Main().");

            Console.WriteLine("And: In the if-statement, we find that OptionA and OptionC are set to true, but OptionB is not set. " +
                "This is the correct result.");

            var info = DataInfo.OptionA | DataInfo.OptionC;

            // See if current flag is set.
            if ((info & DataInfo.OptionA) == DataInfo.OptionA &&
                (info & DataInfo.OptionB) != DataInfo.OptionB && // Not OptionB.
                (info & DataInfo.OptionC) == DataInfo.OptionC)
            {
                Console.WriteLine("Has OptionA, OptionC, but not OptionB.");
            }

            Console.WriteLine("Benchmark, enum. " +
                "Enums are fast. " +
                "They are almost never a performance concern. " +
                "They are just syntactic sugar on a type like int, which is also fast.");

            Console.WriteLine("Version 1: This version of the code tests for an enum value. " +
                "We run it in a tight loop for many iterations.");

            Console.WriteLine("Version 2: This codes tests an int. " +
                "By comparing these versions of the code, we can see any possible performance impact from enums.");

            Console.WriteLine("Result: The enum test takes the same amount of time as the int test—the enum carries no performance penalty over int.");

            const int _max = 10000000;

            // Version 1: use enum in if-statement.
            var s1 = System.Diagnostics.Stopwatch.StartNew();
            var temp1 = TestType.Valid;
            for (int i = 0; i < _max; i++)
            {
                if (temp1 == TestType.Invalid)
                {
                    return;
                }
            }
            s1.Stop();

            // Version 2: use int in if-statement.
            var s2 = System.Diagnostics.Stopwatch.StartNew();
            var temp2 = 0;
            for (int i = 0; i < _max; i++)
            {
                if (temp2 == 2)
                {
                    return;
                }
            }
            s2.Stop();

            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));

            Console.WriteLine("IL, enum. " +
                "We can determine the exact performance of enums by examining the IL (intermediate language) of a compiled C# program. " +
                "Enums are loaded with ldc.i4.");

            Console.WriteLine("And: This means \"load constant integer of 4 bytes.\" " +
                "So an enum of just a constant 4-byte integer, exactly like any other const int.");

            Console.WriteLine("Program: This has an enum, 3 const ints, and 3 static readonly ints. " +
                "The IL shows how the values are loaded onto the evaluation stack.");

            Console.WriteLine("Results: Enums and const ints are loaded with ld.c, so they perform the same. " +
                "But static ints are loaded with ldsfld, which is slower.");

            Method(Test.Cat);
            Method(Test.Dog);
            Method(Test.Rabbit);

            Method(_cat);
            Method(_dog);
            Method(_rabbit);

            Method(_cat2);
            Method(_dog2);
            Method(_rabbit2);

        }
        #endregion

    }
}