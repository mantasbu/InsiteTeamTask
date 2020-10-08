using InsiteTeamTask.MockData;
using InsiteTeamTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace InsiteTeamTask.Repositories.ProductRepo
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDataService _mockData;

        public ProductRepository()
        {
            _mockData = new MockDataService();
        }

        public Product Get(string id)
        {
            return _mockData.Products().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Product> GetAll()
        {
            return _mockData.Products().ToList();
        }
    }
}
