namespace ConsoleInterfaceEnumerable1nov2023
{
    internal class Example1nov2023 : IEnumerable<string>
    {
        private List<string> _elements;

        public Example1nov2023(string[] array)
        {
            this._elements = new List<string>(array);
        }

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            Console.WriteLine("HERE");
            return this._elements.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this._elements.GetEnumerator();
        }

    }
}
