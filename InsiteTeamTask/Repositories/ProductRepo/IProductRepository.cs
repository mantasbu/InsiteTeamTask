using InsiteTeamTask.Models;
using System.Collections.Generic;

namespace InsiteTeamTask.Repositories.ProductRepo
{
    public interface IProductRepository
    {
        Product Get(string id);
        List<Product> GetAll();
    }
}
