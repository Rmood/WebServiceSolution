using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;


namespace DataAccessLayer
{
    public interface IDataService
    {
        IList<Product> GetProducts();
        Product GetProduct(int id);
        void CreateProduct(Product product);

        IList<Client> GetClients();
        Client GetClient(int id);
        void CreateClient(Client client);

        IList<Order> GetOrders();
        Order GetOrder(int id);
        void CreateOrder(Order order);

        IList<Category> GetCategories();
        Category GetCategory(int id);
        void CreateCategory(Category category);
    }
}
