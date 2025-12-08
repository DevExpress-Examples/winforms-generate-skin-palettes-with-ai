using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DevExpress.AI.WinForms.AIGeneratePalette.Demo.Model;

namespace DevExpress.AI.WinForms.AIGeneratePalette.Demo.Infrastructure
{
    public class DataService : ICommonDataService
    {
        List<Customer> customers = [
                new(1, "John", "Doe", "USA", "Homesville", "123 Home Lane", "+1 (323) 555-4321", "55555"),
                new(2, "Sam", "Hill", "Germany", "Berlin", "Friedrichstraße 123", "+49 (30) 1234-5678", "10117"),
                new(3, "Karen", "Holmes", "USA", "Hillsville", "45 Hill St.", "+1 (212) 555-7890", "44444"),
                new(4, "Bobbie", "Valentine", "Germany", "Munich", "Maximilianstraße 45", "+49 (89) 9876-5432", "80539"),
                new(5, "Jennie", "Fuller", "Germany", "Hamburg", "Reeperbahn 89", "+49 (40) 2233-4455", "20359"),
                new(6, "Albert", "Menendez", "USA", "Chicago", "933 Heart St. Suite", "+1 (312) 555-6789", "9900"),
                new(7, "Frank", "Frankson", "France", "Paris", "25 Rue de Rivoli", "+33 (1) 23-45-67-89", "75004"),
                new(8, "Christa", "Christie", "UK", "London", "221B Baker Street", "+44 (20) 7946-0958", "NW1 6XE"),
                new(9, "Jimmie", "Jones", "USA", "Newman", "900 Newman Center.", "+1 (312) 555-6789", "89123"),
                new(10, "Alfred", "Newman", "Germany", "Frankfurt", "Goethestraße 10", "+49 (69) 1122-3344", "60313"),
                new(11, "Benjamin", "Johnson", "UK", "Manchester", " 50 Deansgate", "+44 (161) 555-6789", "M3 2BW"),
                new(12, "Alex", "James", "USA", "Los Angeles", "349 Graphic Design L", "+1 (305) 555-9876", "12211"),
                new(13, "Beau", "Alessandro", "UK", "Birmingham", "30 New Street", "+44 (121) 555-4321", "B2 4ND"),
                new(14, "Bruce", "Cambell", "USA", "San Francisco", "350 Market Street", "+1 (415) 555-1234", "94103"),
                new(15, "Cindy", "Haneline", "USA", "Houston", "600 Main Street", "+1 (713) 555-5678", "77002"),
                new(16, "Andrea", "Deville", "France", "Bordeaux", "14 Cours de l'Intendance", "+33 (5) 56-78-90-12", "33000"),
                new(17, "Anita", "Ryan", "UK", "Cardiff", "30 Castle Street", "+44 (29) 555-1234", "CF10 1BT"),
                new(18, "George", "Bunkelman", "UK", "Liverpool", "100 Albert Dock", "+44 (151) 555-6789", "L3 4AA"),
                new(19, "Anita", "Cardle", "USA", "Seattle", "1200 Pine Street", "+1 (206) 555-8765", "98101"),
                new(20, "Andrew", "Carter", "Germany", "Stuttgart", "Königstraße 20", "+49 (711) 6543-2100", "70173"),
                new(21, "Almas", "Bunch", "USA", "Boston", "75 Beacon Street", "+1 (617) 555-4321", "02108"),
                new(22, "Abigail", "Hazel", "UK", "Glasgow", "75 Buchanan Street", "+44 (141) 555-4321", "G1 3HL"),
                new(23, "Anthony", "Vicars", "Germany", "Düsseldorf", "Königsallee 85", "+49 (211) 7894-5678", "40212"),
                new(24, "Dora", "Geeter", "UK", "Bristol", "20 Queen Square", "+44 (117) 555-8765", "BS1 4ND"),
                new(24, "Anthony", "Boyd", "USA", "Denver", "1500 Blake Street", "+1 (303) 555-7890", "80202"),
                new(24, "Dora", "Catto", "USA", "Atlanta", "200 Peachtree Street", "+1 (404) 555-2345", "30303"),
                ];
        List<Product> products = [
                new(101, "Zaanse koeken", 9.5m),
                new(102, "Teatime Chocolate Biscuits", 9.2m),
                new(103, "Sir Rodney's Scones", 10.0m),
                new(104, "Filo Mix", 7.0m),
                new(105, "Tourtière", 7.45m),
                new(106, "Nord-Ost Matjeshering", 25.89m),
                new(107, "Pâté chinois", 24.0m),
                new(108, "Gnocchi di nonna Alice", 38.0m),
                new(109, "Sasquatch Ale", 14.0m),
                new(110, "Gravad lax", 26.0m),
                ];
        List<Order> orders;

        public DataService()
        {
            orders = GenerateOrders(150);
        }
        public IEnumerable<Customer> GetCustomers() => customers;
        public IEnumerable<Product> GetProducts() => products;
        public IEnumerable<Order> GetOrders() => orders;
        List<Order> GenerateOrders(int count)
        {
            Random random = new Random();
            var generatedOrders = new List<Order>();
            for (int i = 1; i <= count; i++)
            {
                var customer = customers[random.Next(customers.Count)];
                var order = new Order
                {
                    Id = i,
                    Customer = customer,
                    OrderDate = DateTime.Now.AddDays(-random.Next(1, 500)),
                    Items = new ObservableCollection<OrderItem>()
                };

                int itemsCount = random.Next(1, 5);
                for (int j = 0; j < itemsCount; j++)
                {
                    var product = products[random.Next(products.Count)];
                    order.Items.Add(new OrderItem
                    {
                        Id = i * 10 + j,
                        Order = order,
                        Product = product,
                        Quantity = random.Next(1, 10)
                    });
                }

                customer.Orders.Add(order);
                generatedOrders.Add(order);
            }
            return generatedOrders;
        }
    }
    public interface ICommonDataService
    {
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Order> GetOrders();
        IEnumerable<Product> GetProducts();
    }
}
