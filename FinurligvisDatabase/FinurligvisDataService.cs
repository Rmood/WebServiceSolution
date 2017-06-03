using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DataAccessLayer;

namespace FinurligvisDatabase 
{
    public class FinurligvisDataService : IDataService
    {
        public IList<Product> GetProducts()
        {
            using (var context = new FinurligvisContext())
            {
                return context.Products.ToList();
            }
        }

        public Product GetProduct(int id)
        {
            using (var context = new FinurligvisContext())
            {
                return context.Products.Find(id);
            }
        }

        public void CreateProduct(Product product)
        {
            using (var context = new FinurligvisContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public IList<Client> GetClients()
        {
            using (var context = new FinurligvisContext())
            {
                return context.Clients.ToList();
            }  
        }

        public Client GetClient(int id)
        {
            using (var context = new FinurligvisContext())
            {
                return context.Clients.Find(id);
            }
        }

        public void CreateClient(Client client)
        {
            using (var context = new FinurligvisContext())
            {
                context.Clients.Add(client);
                context.SaveChanges();
            }
        }

        public IList<Order> GetOrders()
        {
            using (var context = new FinurligvisContext())
            {
                return context.Orders.ToList();
            }

        }
        public Order GetOrder(int id)
        {
            using (var context = new FinurligvisContext())
            {
                return context.Orders.Find(id);
            }
               
        }

        public void CreateOrder(Order order)
        {
            using (var context = new FinurligvisContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
               
        }

        public IList<Category> GetCategorys()
        {
            using (var context = new FinurligvisContext())
            {
                return context.Categorys.ToList();
            }

        }

        public Category GetCategory(int id)
        {
            using (var context = new FinurligvisContext())
            {
                return context.Categorys.Find(id);
            }   
        }

        public void CreateCategory(Category category)
        {
           using (var context = new FinurligvisContext()) 
            {
                context.Categorys.Add(category);
                context.SaveChanges();
            }
        }
    }
}
