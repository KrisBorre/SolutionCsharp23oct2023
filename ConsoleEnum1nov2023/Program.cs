internal class Program
{
    #region Flags

    [Flags]
    enum FileAttributes
    {
        None = 0,
        Cached = 1,
        Current = 2,
        Obsolete = 4,
    }

    [Flags]
    enum RenderType
    {
        None = 0x0,
        DataUri = 0x1,
        GZip = 0x2,
        ContentPage = 0x4,
        ViewPage = 0x8,
        HomePage = 0x10 // Next two values could be 0x20, 0x40
    }

    static void Check(RenderType type)
    {
        // Switch on the flags.
        switch (type)
        {
            case RenderType.ContentPage | RenderType.DataUri | RenderType.GZip:
                {
                    Console.WriteLine("content, datauri, gzip");
                    break;
                }
            case RenderType.ContentPage | RenderType.GZip: // first match
                {
                    Console.WriteLine("content, gzip");
                    break;
                }
            case RenderType.ContentPage:
                {
                    Console.WriteLine("content");
                    break;
                }
            case RenderType.ViewPage | RenderType.DataUri | RenderType.GZip: // second match
                {
                    Console.WriteLine("view, datauri, gzip");
                    break;
                }
            case RenderType.ViewPage | RenderType.GZip:
                {
                    Console.WriteLine("view, gzip");
                    break;
                }
            case RenderType.ViewPage:
                {
                    Console.WriteLine("view");
                    break;
                }
            case RenderType.HomePage | RenderType.DataUri | RenderType.GZip:
                {
                    Console.WriteLine("home, datauri, gzip");
                    break;
                }
            case RenderType.HomePage | RenderType.GZip:
                {
                    Console.WriteLine("home, gzip");
                    break;
                }
            case RenderType.HomePage:
                {
                    Console.WriteLine("home");
                    break;
                }
        }
    }

    #endregion

    private static void Main(string[] args)
    {
        #region Flags
        {
            // https://www.dotnetperls.com/enum-flags
            Console.WriteLine("Flags allow an enum value to contain many values. " +
                "An enum type with the [Flags] attribute can have multiple constant values assigned to it.");

            Console.WriteLine("Flags can be removed or added. " +
                "We can specify multiple flags with the \"or\" operator.");

            Console.WriteLine("First example. This program introduces a FileAttributes enum. " +
                "We use the values 0, 1, 2, 4 to indicate the underlying bits for each value — we should double each value to avoid conflicts.");

            Console.WriteLine("Operators: We use bitwise operators, like OR and AND, with enum flags. " +
                "We use \"NOT\" to remove a flag from an enum.");

            // Create new enum instance with flags.
            Console.WriteLine("SET CACHED AND CURRENT FLAGS");
            var attributes = FileAttributes.Cached | FileAttributes.Current;

            // See if current flag is set.
            if ((attributes & FileAttributes.Current) == FileAttributes.Current)
            {
                Console.WriteLine("File is current");
            }

            // See if obsolete flag is not set.
            if ((attributes & FileAttributes.Obsolete) != FileAttributes.Obsolete)
            {
                Console.WriteLine("File is not obsolete");
            }

            // Remove current flag.
            Console.WriteLine("REMOVE CURRENT FLAG");
            attributes &= ~FileAttributes.Current;

            // See if current flag is set again.
            if ((attributes & FileAttributes.Current) != FileAttributes.Current)
            {
                Console.WriteLine("File is not current");
            }

            Console.WriteLine("Example, switch. This example shows an enum with 6 bit flags in it. " +
                "Notice how the word [Flags] appears on top of the enum, with the square brackets.");

            Console.WriteLine("Switch: The method Check shows how to switch on enum flags. " +
                "We act on combinations of the flags in a constant-time expression.");

            Console.WriteLine("Note: The \" | \" operator is used in the cases. " +
                "This means the values are combined.");

            Console.WriteLine("Values: The values 0x0, 0x1, 0x2, 0x4 are powers of 2. " +
                "Powers of 2 contain one bit set, moving from the first to the final bit.");

            Console.WriteLine("Tip: You could use the decimal values, 0, 1, 2, 4, 8 instead. " +
                "This might be clearer.");

            // 1.
            // Set the first type.
            RenderType type1 = RenderType.ContentPage;

            // 2.
            // Set the second type if the condition matches.
            if (true)
            {
                type1 |= RenderType.GZip;
            }

            // 3.
            // Check the enum flags.
            Check(type1); // content, gzip

            // 4.
            // Set a new enum in three statements.
            RenderType type2 = RenderType.ViewPage;
            type2 |= RenderType.DataUri;
            type2 |= RenderType.GZip;

            // 5.
            // See if the enum contains this flag.
            if ((type2 & RenderType.DataUri) == RenderType.DataUri)
            {
                Console.WriteLine("True");
            }

            // 6.
            // See if the enum contains this flag.
            if ((type2 & RenderType.ContentPage) == RenderType.ContentPage)
            {
                throw new Exception();
            }

            // 7.
            // Check the enum flags.
            Check(type2); // view, datauri, gzip

            Console.WriteLine("Notes, operators. " +
                                "The \" |= \" operator actually adds a flag to the enum, so the enum now contains two flag bits. " +
                                "You can use \" |= \" to add bits, while & will test bits without setting them.");

            Console.WriteLine("And: Bitwise AND, which you use with &, returns a value with 1 in the targeted bit if both values contain the bit.");

            Console.WriteLine("Tip: You can therefore AND two values together and test the result for the target bit.");

            Console.WriteLine("Also: Bitwise OR, \" | \", returns 1 in the bit if either value has it set. " +
                "It can be used in switch, setting all bits in the cases.");

            Console.WriteLine("You cannot extend enum flags as much as a regular enum. " +
                "If you need 100 enum values, you should use separate integer enums.");

        }
        #endregion

    }
}