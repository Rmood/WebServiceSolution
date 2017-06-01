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
    }
}
