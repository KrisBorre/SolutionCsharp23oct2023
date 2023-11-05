namespace ConsoleInterfaceEnumerable2nov2023
{
    internal class Default2nov2023
    {
        public void Click()
        {
            foreach (var customer in GetAllCustomer())
            {
                Console.WriteLine("Name: " + customer.Name + "<br> " + "City: " + customer.City + " <br> "
                          + "Mobile " + customer.Mobile + "<br> " + "Amount: " + customer.Amount.ToString("c") + "<br>" + "-----" + "<br>");
            }
        }

        private Customer2nov2023[] customers = new Customer2nov2023[]
        {
    new Customer2nov2023 { Name = "Vithal Wadje", City = "Mumbai", Mobile = 99999999999, Amount = 89.45 },
    new Customer2nov2023 { Name = "Sudhir Wadje", City = "Latur", Mobile = 8888888888, Amount = 426.00 },
    new Customer2nov2023 { Name = "Anil", City = "Delhi", Mobile = 7777777777, Amount = 5896.20 }
        };

        public IEnumerable<Customer2nov2023> GetAllCustomer()
        {
            return customers;
        }
    }
}
