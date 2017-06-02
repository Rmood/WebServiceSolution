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
    }
}
