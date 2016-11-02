using System;
using System.Collections.Generic;
using System.Linq;
using _01.NorthwindEntities;

namespace _03_05.NorthwindStatistics
{
    internal class NorthwindStatistics
    {
        internal static void Main()
        {
            //// Task 03 Demo
            var customers = GetCustomers(1997, "Canada");
            PrintData(customers);           

            //// Task 04 Demo
            var otherCustomers = GetCustomersByNativeQuery(1997, "Canada");
            PrintData(otherCustomers);

            //// Task 05 Demo
            var beginDate = new DateTime(1996, 1, 1);
            var endDate = new DateTime(1996, 12, 31);
            var sales = GetSales("RJ", beginDate, endDate);
            PrintData(sales, "Order No: ");
        }

        //// 03. Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
        private static IList<string> GetCustomers(int ordersYear, string shippedTo)
        {
            var customers = new List<string>();
            using (NorthwindEntities db = new NorthwindEntities())
            {
                customers = db
                    .Orders
                    .Where(o => o.OrderDate.Value.Year == ordersYear)
                    .Where(o => o.ShipCountry == shippedTo)
                    .Join(db.Customers,
                        o => o.CustomerID, c => c.CustomerID,
                        (o, c) => c.ContactName
                    )
                    .Distinct()
                    .ToList();
            }

            return customers;
        }

        //// 04. Implement previous by using native SQL query and executing it through the DbContext.
        private static IList<string> GetCustomersByNativeQuery(int ordersYear, string shippedTo)
        {
            var customers = new List<string>();
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var query = $@"SELECT DISTINCT c.ContactName 
                            FROM Orders o 
                            JOIN Customers c
                            ON o.CustomerID = c.CustomerID
                            WHERE o.ShipCountry = '{shippedTo}'
                            AND YEAR(o.OrderDate) = {ordersYear}";
                customers = db.Database.SqlQuery<string>(query).ToList();
            }

            return customers;
        }

        //// 05. Write a method that finds all the sales by specified region and period (start / end dates).
        private static IList<string> GetSales(string region, DateTime startDate, DateTime endDate)
        {
            var sales = new List<string>();
            using (NorthwindEntities db = new NorthwindEntities())
            {
                sales = db
                    .Orders
                    .Where(o => o.ShipRegion == region)
                    .Where(o => o.OrderDate > startDate && o.OrderDate < endDate)
                    .Select(o => o.OrderID.ToString())
                    .ToList();
            }

            return sales;
        }

        private static void PrintData(IList<string> list, string dataInfo = "")
        {
            foreach (var item in list)
            {
                Console.WriteLine(dataInfo + item);
            }

            Console.WriteLine("==============================");
            Console.WriteLine();
        }
    }
}