using System.Linq;
using _01.NorthwindEntities;

namespace NorthwindDAO
{
    public class NorthwindDAO
    {
        internal static void Main()
        {
            //// Adding a new customer
            var customer = new Customer()
            {
                CustomerID = "PENKA",
                CompanyName = "Alabala",
                ContactName = "Pepiii",
                ContactTitle = "alabala",
                Address = "nemaaaa",
                City = "Sofeto"
            };

            AddCustomer(customer);

            //// Updating existing customer
            var customerIdToUpdate ="PENKA";

            EditCustomer(customerIdToUpdate);

            //// Deleting customer
            var customerIdToDelete = "PENKA";

            RemoveCustomer(customerIdToDelete);
        }

        private static void AddCustomer(Customer customer)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        private static void EditCustomer(string customerId)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var customer = db
                    .Customers
                    .Where(c => c.CustomerID == customerId)
                    .FirstOrDefault();

                customer.City = "Pernik";
                db.SaveChanges();
            }
        }

        private static void RemoveCustomer(string customerId)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var customers = db.Customers.ToList();
                var customerToRemove = db
                    .Customers
                    .Where(c => c.CustomerID == customerId)
                    .FirstOrDefault();

                db.Customers.Remove(customerToRemove);                
                db.SaveChanges();
            }
        }
    }
}
