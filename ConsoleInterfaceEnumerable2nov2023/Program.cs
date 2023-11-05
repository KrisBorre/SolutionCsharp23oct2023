namespace ConsoleInterfaceEnumerable2nov2023
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region IEnumerable<T>
            {
                // https://www.codingame.com/playgrounds/213/using-c-linq---a-practical-overview/ienumerablet

                Console.WriteLine("Most C# collections and all C# arrays implement IEnumerable<T>.");

                IEnumerable<int> list = new List<int> { 1, 2, 3 };
                IEnumerable<int> array = new[] { 1, 2, 3 };
                IEnumerable<int> set = new SortedSet<int> { 1, 2, 3 };

                Console.WriteLine("A <T> after an interface name indicates that the interface is generic. " +
                    "This means that it can be used with any data type, and the T is a placeholder for that data type. " +
                    "In the case of IEnumerable<T>, the T represents the data type of the elements within the sequence.");

                Console.WriteLine("An IEnumerable<int> contains a sequence of ints. " +
                    "An IEnumerable<string> contains a sequence of strings. " +
                    "An IEnumerable<object> contains (God help us) a sequence of objects, meaning it can hold, quite literally, anything.");

                //Console.ReadLine();
            }
            #endregion

            #region c-sharpcorner
            {
                // https://www.c-sharpcorner.com/UploadFile/0c1bb2/ienumerable-interface-in-C-Sharp/

                Console.WriteLine("IEnumerable in C# is an interface that defines one method, GetEnumerator which returns an IEnumerator interface. " +
                    "This allows readonly access to a collection then a collection that implements IEnumerable can be used with a for-each statement.");

                Console.WriteLine(@"public class Customer : IEnumerable  
{  
  
    public IEnumerator GetEnumerator()  
    {  
        throw new NotImplementedException();  
    }  
}  ");

                Console.WriteLine(@"IEnumerator is an interface which helps to get current elements from the collection, it has the following two methods:
    MoveNext()
    Reset()");

                Console.WriteLine("MoveNext(): Sets the enumerator to the next element of the collection; it Returns true if the enumerator was successfully set to the next element and false if the enumerator has reached the end of the collection. " +
                    "Reset(): Sets the enumerator to its initial position, which is before the first element in the collection. ");

                Console.WriteLine("IEnumerator Interface has a property named Current which returns the current element in the collection. " +
                    "Let us implement the IEnumerator Interface in class as:");

                Console.WriteLine(@"public class Customer : IEnumerator  
{  
  
     public object Current  
     {  
        get { throw new NotImplementedException(); }  
     }  
  
     public bool MoveNext()  
     {  
        throw new NotImplementedException();  
     }  
  
     public void Reset()  
     {  
        throw new NotImplementedException();  
     }  
}  ");

                Console.WriteLine("IEnumerable vs IEnumerator interface");
                Console.WriteLine("While reading these two names, it can be confusing, so let us understand the difference between these two.");
                Console.WriteLine("IEnumerable and IEnumerator are both interfaces.");
                Console.WriteLine("IEnumerable has just one method called GetEnumerator. " +
                    "This method returns another type which is an interface, that interface is IEnumerator.");
                Console.WriteLine("If we want to implement enumerator logic in any collection class, it needs to implement the IEnumerable interface (either generic or non-generic).");
                Console.WriteLine("IEnumerable has just one method whereas IEnumerator has two methods (MoveNext and Reset) and a property Current.");
                Console.WriteLine("For our understanding, we can say that IEnumerable is a box that contains IEnumerator inside it.");

                Console.WriteLine("In the Customer class file we have created properties of type string, long and double which later on we will use along with IEnumerable generic interface. " +
                    "Now create the Array of type customer class and assign the values to each property as: ");

                Customer2nov2023[] customers = new Customer2nov2023[]
{
    new Customer2nov2023 { Name = "Vithal Wadje", City = "Mumbai", Mobile = 99999999999, Amount = 89.45 },
    new Customer2nov2023 { Name = "Sudhir Wadje", City = "Latur", Mobile = 8888888888, Amount = 426.00 },
    new Customer2nov2023 { Name = "Anil", City = "Delhi", Mobile = 7777777777, Amount = 5896.20 }
};

                Default2nov2023 d = new Default2nov2023();
                d.Click();

                Console.ReadLine();
            }
            #endregion

        }
    }
}