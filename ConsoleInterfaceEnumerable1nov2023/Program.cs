using System.Diagnostics;

namespace ConsoleInterfaceEnumerable1nov2023
{
    internal class Program
    {
        #region see C# program that uses IEnumerable argument

        static void Display(IEnumerable<bool> argument)
        {
            foreach (bool value in argument)
            {
                Console.WriteLine(value);
            }
        }

        #endregion

        #region see C# program that uses 2D array, yield keyword

        static int[,] _grid = new int[15, 15];

        public static IEnumerable<int> GridValues()
        {
            // Use yield return to return all 2D array elements.
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    yield return _grid[x, y];
                }
            }
        }

        #endregion

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello IEnumerable!");

            //Console.SetWindowSize(180, 30);

            #region IEnumerable
            {
                // https://www.dotnetperls.com/ienumerable
                Console.WriteLine("IEnumerable things can be looped over with foreach.");

                #region Initial example
                {
                    Console.WriteLine("Initial example. Here we use IEnumerable as the return value of a query expression. We use it with foreach-loops, and also call extension methods on it.");
                    Console.WriteLine("Part A: An IEnumerable is returned from a query expression. A query that selects ints will be of type IEnumerable<int>.");
                    Console.WriteLine("Part B: On an IEnumerable variable, we can use the foreach-loop. This loop iterates with simple syntax.");
                    Console.WriteLine("Part C: We can apply many transformations to an IEnumerable instance, including the ToList and ToArray conversions.");

                    // Part A: query expression.
                    IEnumerable<int> result = from value in System.Linq.Enumerable.Range(0, 2)
                                              select value;

                    // De variable result bevat 2 elementen, namelijk 0 en 1.

                    // Part B: loop over IEnumerable.
                    foreach (int value in result)
                    {
                        Console.WriteLine(value);
                    }

                    // Part C: we can use extension methods on IEnumerable.
                    double average = result.Average();

                    // average is 0.5

                    // ... Convert IEnumerable.
                    List<int> list = result.ToList();
                    int[] array = result.ToArray();

                    //Console.ReadLine();
                }
                #endregion

                #region C# program that uses IEnumerable argument
                {
                    Console.WriteLine("Arguments. Many classes implement IEnumerable. We can pass them directly to methods that receive IEnumerable arguments. The type parameter must be the same.");
                    Console.WriteLine("Next: Display() receives an IEnumerable argument. We can pass Lists or arrays to it.");
                    Console.WriteLine("Also: We can implement IEnumerable on a type to provide support for the foreach-loop. This is done through the GetEnumerator method.");

                    Display(new List<bool> { true, false, true });

                    //Console.ReadLine();
                }
                #endregion

                #region see C# program that uses 2D array, yield keyword
                {
                    Console.WriteLine("2D array. IEnumerable works with a 2D array. " +
                        "It enables a foreach-loop over the values in a 2D or jagged array. " +
                        "We create a custom method that returns IEnumerable.");
                    Console.WriteLine("Foreach: We use IEnumerable and the foreach-loop to access, in sequence, all items in a 2D array. " +
                        "We can abstract the loop itself out.");
                    Console.WriteLine("Here: This example shows the yield contextual keyword in a method that returns IEnumerable<T>. ");
                    Console.WriteLine("Generic: The return value is a generic IEnumerable collection of ints. " +
                        "We must specify the int in angle brackets.");

                    // Initialize some elements in 2D array.
                    _grid[0, 1] = 4;
                    _grid[4, 4] = 5;
                    _grid[14, 2] = 3;

                    // Sum values in 2D array.
                    int sum = 0;
                    foreach (int value in GridValues())
                    {
                        sum += value;
                    }
                    // Write result.
                    Console.WriteLine("SUMMED 2D ELEMENTS: " + sum); // 12

                    //Console.ReadLine();
                }
                #endregion

                #region C# program that implements IEnumerable
                {
                    Console.WriteLine("In a class, the foreach-loop is not by default supported. " +
                        "A GetEnumerator method (often part of the IEnumerable interface) is required.");

                    Console.WriteLine("his example implements the IEnumerable interface on an Example class. " +
                        "The class contains a List, and for GetEnumerator, we use the List's GetEnumerator method.");

                    Console.WriteLine("So: We forward the details of the implementation to the List." +
                        "Our IEnumerable implementation relies on another.");

                    Console.WriteLine("Main: Here we call the Example class constructor, which populates the _elements field.");

                    Console.WriteLine("Foreach: The foreach-loop in the Main method implicitly (secretly) calls the GetEnumerator method." +
                        "So \"HERE\" is written.");

                    Console.WriteLine("Result: The program compiles." +
                        "The foreach loop refers to the List's Enumerator and loops over the elements of the List.");

                    Example1nov2023 example = new Example1nov2023(new string[] { "cat", "dog", "bird" });

                    // The foreach-loop calls the generic GetEnumerator method.
                    // ... It then uses the List's Enumerator.
                    foreach (string element in example)
                    {
                        Console.WriteLine(element);
                    }

                    //Console.ReadLine();
                }
                #endregion


                #region C# program that uses Enumerable.Range
                {
                    Console.WriteLine("Some methods, like Enumerable.Range(), make it easier to create IEnumerable collections. " +
                        "We do not need to create a separate array.");

                    Console.WriteLine("Program: We test Enumerable. " +
                        "Range, which returns an IEnumerable collection." +
                        "We enumerate its return value with foreach.");

                    Console.WriteLine("Info: Other methods, like Enumerable." +
                        "Repeat and Empty, are available. " +
                        "They can be useful in certain programs.");

                    // Summary:
                    //     Generates a sequence of integral numbers within a specified range.
                    //
                    // Parameters:
                    //   start:
                    //     The value of the first integer in the sequence.
                    //
                    //   count:
                    //     The number of sequential integers to generate.
                    //
                    // Returns:
                    //     An IEnumerable<Int32> in C# or IEnumerable(Of Int32) in Visual Basic that contains
                    //     a range of sequential integral numbers.
                    //
                    // Exceptions:
                    //   T:System.ArgumentOutOfRangeException:
                    //     count is less than 0.-or- start + count -1 is larger than System.Int32.MaxValue.

                    // Get IEnumerable from Enumerable.Range and loop over it.
                    foreach (int value in System.Linq.Enumerable.Range(start: 100, count: 2))
                    {
                        Console.WriteLine("RANGE(100, 2): {0}", value);
                    }

                    foreach (int value in System.Linq.Enumerable.Range(start: 5, count: 5))
                    {
                        Console.WriteLine("RANGE(5, 5): {0}", value);
                    }

                    //Console.ReadLine();
                }
                #endregion


                #region C# program that tests IEnumerable performance
                {
                    Console.WriteLine("A single IEnumerable method can reduce code size — this has speed advantages. " +
                        "For numeric methods, though, using an array directly is usually a faster approach.");

                    Console.WriteLine("Version 1: We loop over the 3 elements in an int array with for each, and sum them. " +
                        "No IEnumerable is involved.");

                    Console.WriteLine("Version 2: We use AsEnumerable to get an IEnumerable of the int array. " +
                        "Then we use foreach over the IEnumerable.");

                    Console.WriteLine("Result: The IEnumerable foreach-loop is much slower. " +
                        "It is best to access arrays directly for most numeric operations.");

                    const int _max = 1000000;

                    int[] values = { 10, 20, 30 };

                    // Version 1: loop over array directly.
                    var s1 = Stopwatch.StartNew();
                    for (int i = 0; i < _max; i++)
                    {
                        int sum = 0;
                        foreach (int value in values)
                        {
                            sum += value;
                        }
                        if (sum == 0)
                        {
                            Console.WriteLine("Dit wordt niet uitgevoerd.");
                            return;
                        }
                    }
                    s1.Stop();

                    // Version 2: convert array to IEnumerable and loop over IEnumerable elements.
                    var s2 = Stopwatch.StartNew();
                    for (int i = 0; i < _max; i++)
                    {
                        int sum = 0;
                        var enumerable = values.AsEnumerable();
                        foreach (int value in enumerable)
                        {
                            sum += value;
                        }
                        if (sum == 0)
                        {
                            Console.WriteLine("Dit wordt niet uitgevoerd.");
                            return;
                        }
                    }
                    s2.Stop();

                    Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns")); // 13,33 ns
                    Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns")); // 42,67 ns

                    Console.WriteLine("Implement, shortcut. " +
                        "In Visual Studio we can implement an interface with some help. " +
                        "Hover the mouse over the IEnumerable name after specifying it.");

                    Console.WriteLine("Then: Select from the menu one of the options. " +
                        "The first is probably the best choice.");

                    Console.WriteLine("Yield. This keyword is placed before \"return\". " +
                        "It is used in methods that return IEnumerable. " +
                        "We can use yield to \"save the state\" of the function after the return.");

                    //Console.ReadLine();
                }
                #endregion


            }
            #endregion
        }
    }
}