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
    }
}
