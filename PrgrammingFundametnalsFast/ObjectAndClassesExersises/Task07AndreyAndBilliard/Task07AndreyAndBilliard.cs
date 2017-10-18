using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07AndreyAndBilliard
{
    class Client
    {

        public string Name { get; set; }

        public Dictionary<string, int> Shoplist { get; set; }

        public double Bill { get; set; }

        public Client(string name, Dictionary<string, int> shopList)
        {
            this.Name = name;

            this.Shoplist = shopList;
        }
    }
        class Task07AndreyAndBilliard
    {
        static void Main(string[] args)
        {

            Dictionary<string, double> stocks = new Dictionary<string, double>();

            var howManyStocks = int.Parse(Console.ReadLine());

            Dictionary<string, Client> customers = new Dictionary<string, Client>();

            for (int i = 0; i < howManyStocks; i++)
            {
                var input = Console.ReadLine().Split('-');

                stocks[input[0]] = double.Parse(input[1]);
            }

            var clientInput = Console.ReadLine().Split('-', ',');

            while (clientInput[0] != "end of clients")
            {
                var clientName = clientInput[0];

                var productName = clientInput[1];

                var quantity = int.Parse(clientInput[2]);

                clientInput = Console.ReadLine().Split('-', ',');

                if (stocks.ContainsKey(productName))
                {
                    var currentproduct = stocks[productName];

                    var currentClient = new Client(clientName, new Dictionary<string, int>());

                    if (!customers.ContainsKey(clientName))
                    {
                        customers[clientName] = currentClient;

                       customers[clientName].Bill = 0;
                    }

                    if (!customers[clientName].Shoplist.ContainsKey(productName))
                    {
                        customers[clientName].Shoplist[productName] = 0;
                    }

                    customers[clientName].Shoplist[productName] += quantity;

                    customers[clientName].Bill += quantity * stocks[productName];

                }
            }

            foreach (var customer in customers.Values.OrderBy(n => n.Name))
            {
                Console.WriteLine($"{customer.Name}");

                foreach (var stock in customer.Shoplist)
                {
                    Console.WriteLine($"-- {stock.Key} - {stock.Value}");

                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {customers.Select(n=>n.Value.Bill).Sum():f2}");
        }
    }
}
