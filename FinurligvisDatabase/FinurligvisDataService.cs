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
    }
}
