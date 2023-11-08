internal class Program
{
    #region Enum.GetName, GetNames: Get String Array From Enum

    enum MedicationType
    {
        Default,
        Antipyretic,
        Corticosteriod,
        Cytotoxic,
        Decongestant,
        Expectorant
    };

    #endregion

    private static void Main(string[] args)
    {
        #region Enum.GetName, GetNames: Get String Array From Enum
        {
            // https://www.dotnetperls.com/enum-getname
            Console.WriteLine("An enum type has names. " +
                "These names are string representations of the enum values. " +
                "The .NET Framework provides the Enum.GetName and Enum.GetNames methods.");

            Console.WriteLine("These methods require the typeof operator. " +
                "They return a string or a string array. " +
                "With GetNames, we can get many names at once.");

            Console.WriteLine("GetName example. The first argument to the Enum.GetName method is a Type. " +
                "And this is easily provided with the result of the typeof operator.");

            Console.WriteLine("And: The second argument is an object: this object must be of the same type as the backing field for the enum.");

            Console.WriteLine("Here: An int is provided (with the value 3) and the correct MedicationType is returned.");

            string name = Enum.GetName(typeof(MedicationType), MedicationType.Cytotoxic); // Cytotoxic
            Console.WriteLine(name); // Cytotoxic

            name = Enum.GetName(typeof(MedicationType), MedicationType.Decongestant); // Decongestant
            Console.WriteLine(name); // Decongestant

            name = Enum.GetName(typeof(MedicationType), 3); // Cytotoxic
            Console.WriteLine(name); // Cytotoxic

            name = Enum.GetName(typeof(MedicationType), 0); // Default
            Console.WriteLine(name); // Default

            Console.WriteLine("Enum.GetNames. This method also requires the Type pointer. " +
                "This means you can pass it the typeof(Identifier) where Identifier is the identifier for your enumerated type.");

            Console.WriteLine("Tip: The typeof operator invokes reflection and the Enum.GetNames method also internally accesses the metadata representation in memory.");

            Console.WriteLine("Next: This program shows how an enumerated type of medication types is accessed in a string array.");

            Console.WriteLine("Main: Here Enum.GetNames() is invoked. " +
                "Enum.GetNames does not use an instance of an enumeration to be called.");

            Console.WriteLine("GetNames: This is a static method. " +
                "We pass it a Type object as the parameter. " +
                "The typeof expression returns that Type object.");

            var names = Enum.GetNames(typeof(MedicationType));

            // Write the enum names separated by a space.
            Console.WriteLine(string.Join(" ", names)); // Default Antipyretic Corticosteriod Cytotoxic Decongestant Expectorant


            Console.ReadLine();
        }
        #endregion
    }
}